using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;
[AosObject(name: "����")]
public class Pmpsh : AosObjectBase
{
    [SerializeField] private MovebleObject _nmsh;

    [AosAction(name: "������� ��������� ������� true - ��������, false - ����������")]
    public void SetCondition(bool value)
    {
        _nmsh.SetCondition(value);
    }

    [AosAction(name: "��������� �������� ������� ������� �� ������ ��������� �� ��������")]
    public void RepairNmsh()
    {
        _nmsh.RepairObject();
    }

}
