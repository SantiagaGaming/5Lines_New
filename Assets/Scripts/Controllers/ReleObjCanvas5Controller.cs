using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ReleObjCanvas5Controller : MonoBehaviour
{
    public UnityAction<bool> NmshConditionEvent;

    [SerializeField] private ReleObjCanvas5Viev _viev;
    [SerializeField] private NmshBfk[] _nmshBfks;

    private void OnEnable()
    {
        _viev.RepairButtonTapEvent += OnChangeNmshBfk;
        _viev.WatchButtonTapEvent += OnShowObjectCondition;
    }
    private void OnDisable()
    {
        _viev.RepairButtonTapEvent -= OnChangeNmshBfk;
        _viev.WatchButtonTapEvent -= OnShowObjectCondition;
    }
    private void OnChangeNmshBfk(int number)
    {
        _nmshBfks[number].RepairNmsh();
    }
    private void OnShowObjectCondition(int number)
    {
        if (_nmshBfks[number].GetCondition())
        {
            NmshConditionEvent?.Invoke(true);
        }
        else
        {
            NmshConditionEvent?.Invoke(false);
        }

    }
}
