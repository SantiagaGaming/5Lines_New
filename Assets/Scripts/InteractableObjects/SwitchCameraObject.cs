using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using UnityEngine.Events;



public class SwitchCameraObject : MonoBehaviour, IClickAble, ICameraObject, IHoverAble
{
    public UnityAction<ICameraObject> SwitchCameraEvent;
    public UnityAction<string> GetNameOfObjectEvent;

    [SerializeField] protected GameObject _camera;
    [SerializeField] protected GameObject _canvas;
    [SerializeField] protected GameObject _canIterractSign;

    [SerializeField] protected string _nameOfObject;

    protected CameraSwitchContoller _cameraSwitch;
    protected GameCanvasViev _gameCanvasViev;

    private void Start()
    {
        _gameCanvasViev = _canvas.GetComponent<GameCanvasViev>();
        _cameraSwitch = FindObjectOfType<CameraSwitchContoller>();
    }

    public void DisableCamera()
    {
        _camera.SetActive(false);
        _canvas.SetActive(false);
    }
    public virtual void OnClicked()
    {
        if(_cameraSwitch.CanSwitch)
        {
            SwitchCamera();
            _canIterractSign.SetActive(false);
        }

    }
    protected void SwitchCamera()
    {
        _camera.SetActive(true);
        _canvas.SetActive(true);
        SetGameCanvasViev();
        GetNameOfObjectEvent?.Invoke("");
        SwitchCameraEvent?.Invoke(this);
    }
   protected void SetGameCanvasViev()
    {
        InventController tempInvent = FindObjectOfType<InventController>();
        tempInvent.SetCurrentCanvas(_gameCanvasViev);
    }

    public void OnHoverIn()
    {
        _canIterractSign.SetActive(true);
        GetNameOfObjectEvent?.Invoke(_nameOfObject);
    }
    public void OnHoverOut()
    {
        _canIterractSign.SetActive(false);
        GetNameOfObjectEvent?.Invoke("");
    }
}
