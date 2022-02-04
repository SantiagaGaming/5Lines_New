using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InventoryViev : MonoBehaviour
{
    public UnityAction BackButtonTapEvent;
    public UnityAction MapButtonTapEvent;
    public UnityAction MeasureButtonTapEvent;
    public UnityAction RepairButtonTapEvent;
    public UnityAction RadioButtonTapEvent;
    public UnityAction WatchButtonTapEvent;
    public UnityAction TouchButtonTapEvent;

    [SerializeField] private Button _backButton;
    [SerializeField] private Button _mapButton;
    [SerializeField] private Button _measureButton;
    [SerializeField] private Button _repairButton;
    [SerializeField] private Button _radioButton;
    [SerializeField] private Button _watchButton;
    [SerializeField] private Button _touchButton;

    [SerializeField] private GameObject _mapImage;
    [SerializeField] private GameObject _messageWindow;

    [SerializeField] private Text _messageWindowText;

    private void Start()
    {
        _backButton.onClick.AddListener(() => { BackButtonTapEvent?.Invoke(); });
        _mapButton.onClick.AddListener(() => { MapButtonTapEvent?.Invoke(); ShowMessageWindow(false); });
        _measureButton.onClick.AddListener(() => { MeasureButtonTapEvent?.Invoke(); ShowMessageWindow(false); });
        _repairButton.onClick.AddListener(() => { RepairButtonTapEvent?.Invoke(); ShowMessageWindow(false); });
        _radioButton.onClick.AddListener(() => { RadioButtonTapEvent?.Invoke(); ShowMessageWindow(false); });
        _watchButton.onClick.AddListener(() => { WatchButtonTapEvent?.Invoke();ShowMessageWindow(false); });
        _touchButton.onClick.AddListener(() => { TouchButtonTapEvent?.Invoke(); ShowMessageWindow(false); });
    }
    public void ShowMap(bool value)
    {
        _mapImage.SetActive(value);
    }
    public void ShowMeasureText(string text)
    {
        _messageWindowText.text = text;
    }
    public void ShowMessageWindow( bool value)
    {
        _messageWindow.SetActive(value);
    }

}
