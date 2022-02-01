using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InventoryViev : MonoBehaviour
{
    public UnityAction BackButtonTapEvent;
    public UnityAction MapButtonTapEvent;
    [SerializeField] private Button _backButton;
    [SerializeField] private Button _mapButton;
    [SerializeField] private GameObject _mapImage;

    private void Start()
    {
        _backButton.onClick.AddListener(() => { BackButtonTapEvent?.Invoke(); });
        _mapButton.onClick.AddListener(() => { MapButtonTapEvent?.Invoke(); });
    }
    public void ShowMap(bool value)
    {
        _mapImage.SetActive(value);
    }

}
