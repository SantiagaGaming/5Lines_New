using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using UnityEngine.Events;



public class SwitchCameraObject : MonoBehaviour, IClickAble, ICameraObject
{
    public UnityAction<ICameraObject> SwitchCameraEvent;
    [SerializeField] private GameObject _camera;

    public void DisableCamera()
    {
        _camera.SetActive(false);
    }

    public void OnClicked()
    {
        SwitchCamera();
    }
    private void SwitchCamera()
    {
        _camera.SetActive(true);
        SwitchCameraEvent?.Invoke(this);
    }

}
