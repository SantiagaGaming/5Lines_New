using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailObject : MonoBehaviour
{
    private bool _serviceable;
    public bool GetRailCondition()
    {
        return _serviceable;
    }
    public void SetCondition(bool value)
    {
        _serviceable = value;
    }
}
