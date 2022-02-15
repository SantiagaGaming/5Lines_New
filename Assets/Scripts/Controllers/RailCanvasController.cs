using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailCanvasController : MonoBehaviour
{
    [SerializeField] private Strelka _strelka;
    [SerializeField] private RailCanvasViev _railCanvasViev;

    private void OnEnable()
    {
        _railCanvasViev.PlusMinusButtonTapEvent += OnSetStrelkaCondition;
    }
    private void OnDisable()
    {
        _railCanvasViev.PlusMinusButtonTapEvent -= OnSetStrelkaCondition;
    }


    private void OnSetStrelkaCondition(bool value)
    {
        _strelka.SetCondition(value);
    }

}
