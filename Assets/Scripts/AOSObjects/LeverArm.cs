using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;


[AosObject(name: "�������� � ���")]
public class LeverArm : AosObjectBase
{
    [SerializeField] private LeverarmDSP _leverarm;


    [AosAction(name: "������� ��������� �������� 0-���� 1 -�����, ��� ���������  - ��������")]
    public void SetRotationSide(int direction)
    {
        _leverarm.Rotate(direction);
    }


}
