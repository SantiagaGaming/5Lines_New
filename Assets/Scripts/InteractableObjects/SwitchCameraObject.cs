using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class SwitchCameraObject : MonoBehaviour, IClickAble, IHoverAble, ICameraObject
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
    public virtual void OnClicked(InteractHand interactHand)
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

    public void OnHoverIn(InteractHand interactHand)
    {
        _canIterractSign.SetActive(true);
        GetNameOfObjectEvent?.Invoke(_nameOfObject);
    }
    public void OnHoverOut(InteractHand interactHand)
    {
        _canIterractSign.SetActive(false);
        GetNameOfObjectEvent?.Invoke("");
    }
    public bool IsHoverable { get; set; } = true;

    public bool IsClickable { get; set; } = true;
}

