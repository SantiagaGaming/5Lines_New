using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;


[AosObject(name: "Лампочка Реле")]
public class ReleLamp : AosObjectBase
{
    [SerializeField] private Lamp _lamp;


    [AosAction(name: "Сменить цвет лампочки: Красный")]
    public void SetLampColor()
    {
        _lamp.ChangeColor();
    }

    [AosAction(name: "Сминить цвет лампочки: Белый")]
    public void ResetoLampColor()
    {
        _lamp.ResetColor();
    }
}
