using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;

[AosObject(name: "�������� �� �����")]
public class RailAnimation : AosObjectBase
{
    [SerializeField] private RailsAnimation _rails;

    [AosAction(name: "�������� ����� ��������")]
    public void AnimateLeft()
    {
        _rails.PlayLeftOKAnimation();
    }
    [AosAction(name: "�������� ������ ��������")]
    public void AnimateRight()
    {
        _rails.PlayRightOKAnimation();
    }

    [AosAction(name: "�������� ����� �������")]
    public void AnimateLeftBroken()
    {
        _rails.PlayLeftBrokenAnimation();
    }
    [AosAction(name: "�������� ������ �������")]
    public void AnimateRightBroken()
    {
        _rails.PlayRightBrokenAnimation();
    }
}