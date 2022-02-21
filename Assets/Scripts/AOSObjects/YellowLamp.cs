using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;


[AosObject(name: "Желтая лампочка")]
public class YellowLamp : AosObjectBase
{
    [SerializeField] private LampDsp _lamp;


    [AosAction(name: "Сминить цвет лампочки: Желтый")]
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
