using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InventoryViev : MonoBehaviour
{
    public UnityAction BackButtonTapEvent;
    [SerializeField] private Button _backButton;

    private void Start()
    {
        _backButton.onClick.AddListener(() => { BackButtonTapEvent?.Invoke(); });
    }

}
