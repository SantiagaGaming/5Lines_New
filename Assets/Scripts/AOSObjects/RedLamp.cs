using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;


[AosObject(name: "Красная лампочка")]
public class RedLamp : AosObjectBase
{
    [SerializeField] private Lamp _lamp;


    [AosAction(name: "Сменить цвет лампочки: Красный")]
    public void SetLampColor()
    {
        _lamp.ChangeColor();
    }

    [AosAction(name: "Сменить цвет лампочки: Черный")]
    public void ResetoLampColor()
    {
        _lamp.ResetColor();
    }
}
