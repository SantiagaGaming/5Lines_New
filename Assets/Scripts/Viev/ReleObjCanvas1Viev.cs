using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ReleObjCanvas1Viev : MonoBehaviour
{
    public UnityAction<Transform, string> MeasureButtonTapEvent;
    [SerializeField] private Button[] _measureButtons;
    private void Start()
    {
        foreach (var Button in _measureButtons)
        {
            Button.onClick.AddListener(() => { MeasureButtonTapEvent?.Invoke(Button.GetComponent<Transform>(), Button.name); });
        }
    }
}
