using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class RailCanvasViev : MonoBehaviour
{
    public UnityAction<int> TouchButtonTapEvent;
    public UnityAction<int> WatchButtonTapEvent;
    public UnityAction<bool> PlusMinusButtonTapEvent;

    [SerializeField] private Button _touchButton1;
    [SerializeField] private Button _touchButton2;

    [SerializeField] private Button _plusStrelkaButton;
    [SerializeField] private Button _minusStrelkaButton;

    [SerializeField] private Button _watchButton1;
    [SerializeField] private Button _watchButton2;



    private void Start()
    {

        _touchButton1.onClick.AddListener(() => { RepairAndHide(0); });
        _touchButton2.onClick.AddListener(() => { RepairAndHide(1); });


        _watchButton1.onClick.AddListener(() => { WatchButtonTapEvent?.Invoke(0); });
        _watchButton2.onClick.AddListener(() => { WatchButtonTapEvent?.Invoke(1); });

        _plusStrelkaButton.onClick.AddListener(() => { PlusMinusButtonTapEvent.Invoke(true); });
        _minusStrelkaButton.onClick.AddListener(() => { PlusMinusButtonTapEvent.Invoke(false); });


    }
    private void RepairAndHide(int number)
    {
        TouchButtonTapEvent?.Invoke(number);
    }
}
