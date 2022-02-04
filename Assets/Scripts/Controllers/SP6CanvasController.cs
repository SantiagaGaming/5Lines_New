using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP6CanvasController : MonoBehaviour
{
    [SerializeField] private SP6CanvasViev _sp6CanvasViev;
    [SerializeField] private ShupController _shupController;
    [SerializeField] private Strelka _strelka;

    private void OnEnable()
    {
        _sp6CanvasViev.ButtonTapEvent += SetShupPosition;
        _sp6CanvasViev.PlusMinusButtonTapEvent += OnSetStrelkaCondition;

    }
    private void OnDisable()
    {
        _sp6CanvasViev.ButtonTapEvent -= SetShupPosition;
        _sp6CanvasViev.PlusMinusButtonTapEvent -= OnSetStrelkaCondition;
    }
    private void SetShupPosition(Transform position, string text)
    {
        _shupController.SetShupPosition(position, text);
    }
    private void OnSetStrelkaCondition(bool value)
    {
        _strelka.SetCondition(value);
    }
}
