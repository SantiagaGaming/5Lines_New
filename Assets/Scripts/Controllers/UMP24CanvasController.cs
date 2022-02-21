using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UMP24CanvasController : MonoBehaviour
{
    public UnityAction<bool> MovableObjectConditionEvent;

    [SerializeField] private UMP24CanvasViev _ump24CanvasViev;
    [SerializeField] private ShupController _shupController;

    [SerializeField] private MovebleObject[] _ump24Parts;

    private void OnEnable()
    {
        _ump24CanvasViev.MeasureButtonTapEvent += SetShupPosition;
        _ump24CanvasViev.RepairButtonTapEvent += OnChangeObjectCondition;
        _ump24CanvasViev.WatchButtonTapEvent += OnShowObjectCondition;
    }
    private void OnDisable()
    {
        _ump24CanvasViev.MeasureButtonTapEvent -= SetShupPosition;
        _ump24CanvasViev.RepairButtonTapEvent -= OnChangeObjectCondition;
        _ump24CanvasViev.WatchButtonTapEvent -= OnShowObjectCondition;
    }
    private void SetShupPosition(Transform position, string text)
    {
            _shupController.SetShupPosition(position, text);
    }

    private void OnChangeObjectCondition(int number)
    {
        _ump24Parts[number].RepairObject();
    }
    private void OnShowObjectCondition(int number)
    {
        if (_ump24Parts[number].GetCondition())
        {
            MovableObjectConditionEvent?.Invoke(true);
        }
        else
        {
            MovableObjectConditionEvent?.Invoke(false);
        }

    }
}

