using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SP6CanvasViev : MonoBehaviour
{
    public UnityAction<Transform, string> ButtonTapEvent;
    public UnityAction<bool> PlusMinusButtonTapEvent;

    [SerializeField] private Button[] _buttons;
    [SerializeField] private Button _plusStrelkaButton;
    [SerializeField] private Button _minusStrelkaButton;
    private void Start()
    {
        foreach (var Button in _buttons)
        {
            Button.onClick.AddListener(() => { ButtonTapEvent?.Invoke(Button.GetComponent<Transform>(), Button.name); });
        }
        _plusStrelkaButton.onClick.AddListener(() => { PlusMinusButtonTapEvent.Invoke(true); });
        _minusStrelkaButton.onClick.AddListener(() => { PlusMinusButtonTapEvent.Invoke(false) ; });
    }
}
