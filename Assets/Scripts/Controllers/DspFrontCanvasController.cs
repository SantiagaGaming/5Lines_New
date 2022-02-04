using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DspFrontCanvasController : MonoBehaviour
{
    [SerializeField] private Strelka _strelka;
    [SerializeField] private DspFrontCanvasViev _dspFrontCanvasViev;

    private void OnEnable()
    {
       _dspFrontCanvasViev.PlusMinusButtonTapEvent += OnSetStrelkaCondition;
    }
    private void OnDisable()
    {
        _dspFrontCanvasViev.PlusMinusButtonTapEvent -= OnSetStrelkaCondition;
    }

    private void OnSetStrelkaCondition(bool value)
    {
        _strelka.SetCondition(value);
    }
}

