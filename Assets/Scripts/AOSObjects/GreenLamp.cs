using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;


[AosObject(name: "Зеленая лампочка")]
public class GreenLamp : AosObjectBase
{
    [SerializeField] private Lamp _lamp;


    [AosAction(name: "Сменить цвет лампочки: Зеленый")]
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
