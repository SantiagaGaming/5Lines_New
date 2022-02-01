using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using UnityEngine.Events;



public class SwitchCameraObject : MonoBehaviour, IClickAble, ICameraObject
{
    public UnityAction<ICameraObject> SwitchCameraEvent;
    [SerializeField] private GameObject _camera;
    [SerializeField] private GameObject _canvas;
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
    }
    private void SwitchCamera()
    {
        _camera.SetActive(true);
        _canvas.SetActive(true);
        SetGameCanvasViev();
        SwitchCameraEvent?.Invoke(this);
    }
    private void SetGameCanvasViev()
    {
        InventController tempInvent = FindObjectOfType<InventController>();
        tempInvent.SetCurrentCanvas(_gameCanvasViev);
    }

}
