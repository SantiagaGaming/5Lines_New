using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DspFrontCanvasViev : MonoBehaviour
{
    public UnityAction<bool> PlusMinusButtonTapEvent;

    [SerializeField] private Button _plusStrelkaButton;
    [SerializeField] private Button _minusStrelkaButton;
    private void Start()
    {
 
        _plusStrelkaButton.onClick.AddListener(() => { PlusMinusButtonTapEvent.Invoke(true); });
        _minusStrelkaButton.onClick.AddListener(() => { PlusMinusButtonTapEvent.Invoke(false); });

    }

}
