using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvasController : MonoBehaviour
{
    [SerializeField] private GameObject _getInteractNameViev;
    [SerializeField] private PlayerCanvasViev _viev;
    [SerializeField] private SwitchCameraObject[] _interactObjects;
    [SerializeField] private Timer _timer;

    private void Start()
    {
        foreach (var switchCameraObject in _interactObjects)
        {
            switchCameraObject.GetNameOfObjectEvent += OnSetInteractText;
        }
    }
    private void Update()
    {
        _viev.ShowTimerText(_timer.ReturnTime());
    }
    private void OnSetInteractText(string value)
    {
        if (value == "")
            _getInteractNameViev.SetActive(false);
        else
        {
            _getInteractNameViev.SetActive(true);
            _viev.ShowInterractText(value);
        }
    }
    public void ControlTimer(bool value)
    {
        _timer.ControlTime(value);
    }
}
