using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;


[AosObject(name: "������ ��������")]
public class YellowLamp : AosObjectBase
{
    [SerializeField] private LampDsp _lamp;


    [AosAction(name: "������� ���� ��������: ������")]
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
