using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using UnityEngine.Events;



public class SwitchCameraObject : MonoBehaviour, IClickAble, ICameraObject, IHoverAble
{
    public UnityAction<ICameraObject> SwitchCameraEvent;
    public UnityAction<string> GetNameOfObjectEvent;

    [SerializeField] private GameObject _camera;
    [SerializeField] private GameObject _canvas;
    [SerializeField] private GameObject _canIterractSign;
    [SerializeField] private string _nameOfObject;

    private GameCanvasViev _gameCanvasViev;
    private void Start()
    {
        _gameCanvasViev = _canvas.GetComponent<GameCanvasViev>();
    }

    public void DisableCamera()
    {
        _camera.SetActive(false);
        _canvas.SetActive(false);
    }
    public void OnClicked()
    {
        SwitchCamera();
        _canIterractSign.SetActive(false);
    }
    private void SwitchCamera()
    {
        _camera.SetActive(true);
        _canvas.SetActive(true);
        SetGameCanvasViev();
        GetNameOfObjectEvent?.Invoke("");
        SwitchCameraEvent?.Invoke(this);
    }
    private void SetGameCanvasViev()
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
