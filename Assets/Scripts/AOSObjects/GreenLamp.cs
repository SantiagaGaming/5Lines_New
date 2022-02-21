using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;


[AosObject(name: "Зеленая лампочка")]
public class GreenLamp : AosObjectBase
{
    [SerializeField] private LampDsp _lamp;


    [AosAction(name: "Сминить цвет лампочки: Зеленый")]
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
