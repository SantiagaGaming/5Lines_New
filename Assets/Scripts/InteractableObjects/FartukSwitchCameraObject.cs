using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FartukSwitchCameraObject : SwitchCameraObject
{
    [SerializeField] private GameObject _roof;
    [SerializeField] private InventoryViev _invetory;

    private void OnEnable()
    {
        _invetory.BackButtonTapEvent += OnCloseFartuk;
    }

    private void OnDisable()
    {
        _invetory.BackButtonTapEvent -= OnCloseFartuk;
    }

    public override void OnClicked()
    {
        StartCoroutine(RoofRotator(true));
        base.OnClicked();
    }
    private void OnCloseFartuk()
    {
        if (_cameraSwitch.CompareObjects(this))
            StartCoroutine(RoofRotator(false));
    }

    private IEnumerator RoofRotator(bool value)
    {
        if (value)
        {

            int x = 0;
            while (x <= 120)
            {
                _roof.transform.localRotation = Quaternion.Euler(x, 0,0 );
                x++;
                yield return new WaitForSeconds(0.001f);
            }

        }
        else
        {
            int x = 120;
            while (x >= 0)
            {
                _roof.transform.localRotation = Quaternion.Euler(x, 0, 0);
                x--;
                yield return new WaitForSeconds(0.001f);
            }
        }
        _cameraSwitch.CanSwitch = true;
    }
}
