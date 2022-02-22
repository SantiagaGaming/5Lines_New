using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SP6CanvasViev : MonoBehaviour
{
    public UnityAction<Transform, string> ButtonTapEvent;
    public UnityAction<bool> PlusMinusButtonTapEvent;
    public UnityAction<int> RepairButtonTapEvent;

    [SerializeField] private Button[] _buttons;
    [SerializeField] private Button _plusStrelkaButton;
    [SerializeField] private Button _minusStrelkaButton;
    [SerializeField] private Button _repairButton;
    private void Start()
    {
        foreach (var Button in _buttons)
        {
            Button.onClick.AddListener(() => { ButtonTapEvent?.Invoke(Button.GetComponent<Transform>(), Button.name); });
        }
        _plusStrelkaButton.onClick.AddListener(() => { PlusMinusButtonTapEvent.Invoke(true); });
        _minusStrelkaButton.onClick.AddListener(() => { PlusMinusButtonTapEvent.Invoke(false) ; });
        _repairButton.onClick.AddListener(() => { RepairAndHide(0);});
    }

    private void RepairAndHide(int number)
    {
        RepairButtonTapEvent?.Invoke(number);
    }
}
