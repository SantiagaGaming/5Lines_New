using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "Левый камень")]
public class StoneLeft : AosObjectBase
{
    [SerializeField] private Stone _stone;

    [AosAction(name: "Сменить состояние объекта true - активен, false - неактивен")]
    public void SetCondition(bool value)
    {
        _stone.EnableStone(value);
    }

}
