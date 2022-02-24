using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;
[AosObject(name: "Правый камень")]
public class StoneRight : AosObjectBase
{
    [SerializeField] private Stone _stone;

    [AosAction(name: "Сменить состояние объекта true - активен, false - неактивен")]
    public void SetCondition(bool value)
    {
        _stone.EnableStone(value);
    }

}
