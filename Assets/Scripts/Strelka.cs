using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Strelka : MonoBehaviour
{
    public UnityAction <bool> GetStrelkaCondition;

    private bool _condition;
    public void SetCondition(bool value)
    {
        _condition = value;
        GetStrelkaCondition?.Invoke(_condition);
    }
    public bool GetCondition()
    {
        return _condition;
    }
}
