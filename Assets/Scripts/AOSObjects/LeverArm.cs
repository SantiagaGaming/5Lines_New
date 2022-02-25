using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;


[AosObject(name: "Рукоятка в ДСП")]
public class LeverArm : AosObjectBase
{
    [SerializeField] private LeverarmDSP _leverarm;


    [AosAction(name: "Сминить положение рукоятки 0-лево 1 -право, все остальное  - середина")]
    public void SetRotationSide(int direction)
    {
        _leverarm.Rotate(direction);
    }


}
