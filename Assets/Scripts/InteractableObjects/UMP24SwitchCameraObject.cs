using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using UnityEngine.Events;
public class UMP24SwitchCameraObject : SwitchCameraObject
{

    [SerializeField] private GameObject _roof;
    [SerializeField] private InventoryViev _invetory;
    [SerializeField] private CameraSwitchContoller _cameraController;

    private bool _isAmimated = false;
    private void OnEnable()
    {
        _invetory.BackButtonTapEvent += OnCloseUMPRoof;
    }

    private void OnDisable()
    {
        _invetory.BackButtonTapEvent -= OnCloseUMPRoof;
    }
    public override void OnClicked()
    {
        StartCoroutine(RoofMover(true));
    }
    private void OnCloseUMPRoof()
    {
        if(_cameraController.CompareObjects(this))
        StartCoroutine(RoofMover(false));
    }

    private IEnumerator RoofMover(bool value)
    {
        if(!_isAmimated)
        {
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
            if(value)
            base.OnClicked();
            _isAmimated = false;
        }
    }
}

