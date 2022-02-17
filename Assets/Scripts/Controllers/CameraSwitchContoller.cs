using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Player.Scripts;
using AosSdk.Core.Scripts;

public class CameraSwitchContoller : MonoBehaviour
{
    [SerializeField] private SwitchCameraObject[] _switchCameraObjects;
    [SerializeField] private GameObject _inventoryViev;
    [SerializeField] private GameObject _playerCrossHair;
    [SerializeField] private SoundPlayer _soundPlayer;

    [HideInInspector] public bool CanSwitch = true;

    private InventoryViev _inventory;
    private ICameraObject _currentCamera;

    private void Awake()
    {
        foreach (var switchCameraObject in _switchCameraObjects)
        {
            switchCameraObject.SwitchCameraEvent += OnDisablePlayerCamera;
        }
        _inventory = _inventoryViev.GetComponent<InventoryViev>();
    }
    private void OnEnable()
    {
        _inventory.BackButtonTapEvent += OnEnablePlayerCamera;
    }
    private void OnDisable()
    {
        _inventory.BackButtonTapEvent -= OnEnablePlayerCamera;
    }
    private void OnDisablePlayerCamera(ICameraObject camera)
    {
            _inventoryViev.SetActive(true);
             Player.Instance.EnableCamera(false);
            _playerCrossHair.SetActive(false);
            ShowDisableCursor(false);
           _currentCamera = camera;
    }
    private void OnEnablePlayerCamera()
    {
        _inventoryViev.SetActive(false);
        Player.Instance.EnableCamera(true);
        _playerCrossHair.SetActive(true);
        ShowDisableCursor(true);
        _currentCamera.DisableCamera();
        _soundPlayer.PlayTapSound();
    }
    private void ShowDisableCursor(bool value)
    {
        if(!value)
        {
            Player.Instance.EnableRayCaster(false);
            Player.Instance.CanMove = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if(value)
        {
            Player.Instance.EnableRayCaster(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Player.Instance.CanMove = true;
        }
    }
    public bool CompareObjects(ICameraObject obj)
    {
        if (obj.Equals(_currentCamera))
            return true;
        else return false;
    }
}
