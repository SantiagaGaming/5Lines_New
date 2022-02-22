using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;


[AosObject(name: "������� ��������")]
public class RedLamp : AosObjectBase
{
    [SerializeField] private Lamp _lamp;


    [AosAction(name: "������� ���� ��������: �������")]
    public void SetLampColor()
    {
        _lamp.ChangeColor();
    }

    [AosAction(name: "������� ���� ��������: �����")]
    public void ResetoLampColor()
    {
        _lamp.ResetColor();
    }
}
