using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class UMP24SwitchCameraObject : SwitchCameraObject
{

    [SerializeField] private GameObject _roof;
    [SerializeField] private InventoryViev _invetory;

    private InteractHand interactHand;

    private bool _isAmimated = false;
    private void OnEnable()
    {
        _invetory.BackButtonTapEvent += OnCloseUMPRoof;
    }

    private void OnDisable()
    {
        _invetory.BackButtonTapEvent -= OnCloseUMPRoof;
    }
    public override void OnClicked(InteractHand interactHand)
    {
        StartCoroutine(RoofMover(true));
    }
    private void OnCloseUMPRoof()
    {
        if(_cameraSwitch.CompareObjects(this))
        StartCoroutine(RoofMover(false));
    }

    private IEnumerator RoofMover(bool value)
    {
        if(!_isAmimated && _cameraSwitch.CanSwitch)
        {
            _cameraSwitch.CanSwitch = false;
            _isAmimated = true;
            int y = 0;
            while (y < 25)
            {
                if (value)
                    _roof.transform.position += new Vector3(0, 0.01f, 0);
                else
                    _roof.transform.position -= new Vector3(0, 0.01f, 0);
                yield return new WaitForSeconds(0.02f);
                y++;
            }
            _cameraSwitch.CanSwitch = true;
            if (value)
                base.OnClicked(interactHand);
            _isAmimated = false;
  
        }
    }
}

