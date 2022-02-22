using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP6CanvasController : MonoBehaviour
{
    [SerializeField] private SP6CanvasViev _sp6CanvasViev;
    [SerializeField] private ShupController _shupController;
    [SerializeField] private Strelka _strelka;
    [SerializeField] private MovebleObject[] _sp6Objects;

    private void OnEnable()
    {
        _sp6CanvasViev.ButtonTapEvent += SetShupPosition;
        _sp6CanvasViev.PlusMinusButtonTapEvent += OnSetStrelkaCondition;
        _sp6CanvasViev.RepairButtonTapEvent += OnChangeObjectCondition;

    }
    private void OnDisable()
    {
        _sp6CanvasViev.ButtonTapEvent -= SetShupPosition;
        _sp6CanvasViev.PlusMinusButtonTapEvent -= OnSetStrelkaCondition;
        _sp6CanvasViev.RepairButtonTapEvent -= OnChangeObjectCondition;
    }
    private void SetShupPosition(Transform position, string text)
    {
        _shupController.SetShupPosition(position, text);
    }
    private void OnSetStrelkaCondition(bool value)
    {
        _strelka.SetCondition(value);
    }
    private void OnChangeObjectCondition(int number)
    {
        _sp6Objects[number].RepairObject();
    }

}
