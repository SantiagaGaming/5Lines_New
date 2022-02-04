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

    [SerializeField] private Button _backButton;
    [SerializeField] private Button _mapButton;
    [SerializeField] private Button _measureButton;
    [SerializeField] private Button _repairButton;

    [SerializeField] private GameObject _mapImage;
    [SerializeField] private GameObject _measureTextImage;

    [SerializeField] private Text _measureText;

    private void Start()
    {
        _backButton.onClick.AddListener(() => { BackButtonTapEvent?.Invoke(); });
        _mapButton.onClick.AddListener(() => { MapButtonTapEvent?.Invoke(); });
        _measureButton.onClick.AddListener(() => { MeasureButtonTapEvent?.Invoke(); });
        _repairButton.onClick.AddListener(() => { RepairButtonTapEvent?.Invoke(); });
    }
    public void ShowMap(bool value)
    {
        _mapImage.SetActive(value);
    }
    public void ShowMeasureText(string text)
    {
        _measureText.text = text;
    }
    public void ShowMeasureTextWindow( bool value)
    {
        _measureTextImage.SetActive(value);
    }

}
