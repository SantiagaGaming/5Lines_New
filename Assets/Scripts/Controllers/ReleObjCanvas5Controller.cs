using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ReleObjCanvas5Controller : MonoBehaviour
{
    public UnityAction<bool> MovableObjectConditionEvent;

    [SerializeField] private ReleObjCanvas5Viev _viev;
    [SerializeField] private MovebleObject[] _nmshBfks;

    private void OnEnable()
    {
        _viev.RepairButtonTapEvent += OnChangeObjectCondition;
        _viev.WatchButtonTapEvent += OnShowObjectCondition;
    }
    private void OnDisable()
    {
        _viev.RepairButtonTapEvent -= OnChangeObjectCondition;
        _viev.WatchButtonTapEvent -= OnShowObjectCondition;
    }
    private void OnChangeObjectCondition(int number)
    {
        _nmshBfks[number].RepairObject();
    }
    private void OnShowObjectCondition(int number)
    {
        if (_nmshBfks[number].GetCondition())
        {
            MovableObjectConditionEvent?.Invoke(true);
        }
        else
        {
            MovableObjectConditionEvent?.Invoke(false);
        }

    }
}
