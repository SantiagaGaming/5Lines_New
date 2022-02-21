using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ReleObjCanvas6Controller : MonoBehaviour
{
    public UnityAction<bool> ObjConditionEvent;

    [SerializeField] private ReleObjCanvas6Viev _viev;
    [SerializeField] private MovebleObject[] _objects;

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
        _objects[number].RepairObject();
    }
    private void OnShowObjectCondition(int number)
    {
        if (_objects[number].GetCondition())
        {
            ObjConditionEvent?.Invoke(true);
        }
        else
        {
            ObjConditionEvent?.Invoke(false);
        }

    }
}
