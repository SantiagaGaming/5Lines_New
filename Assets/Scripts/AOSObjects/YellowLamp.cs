using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;


[AosObject(name: "Желтая лампочка")]
public class YellowLamp : AosObjectBase
{
    [SerializeField] private Lamp _lamp;


    [AosAction(name: "Сминить цвет лампочки: Желтый")]
    public void SetLampColor()
    {
        _lamp.ChangeColor();
    }

    [AosAction(name: "Сминить цвет лампочки: Черный")]
    public void ResetoLampColor()
    {
        _lamp.ResetColor();
    }
}
