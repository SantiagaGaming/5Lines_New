using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;

[AosObject(name: "����� � �������� � ���")]
public class FromCorridorToDspDoor : AosObjectBase
{
    [SerializeField] private Door _door;

    [AosAction(name: "�������� � ��� �� �������� �����")]
    public void StartTeleporting()
    {
        _door.StartTeleporting();
    }

    [AosEvent(name: "�������� � ��� �� �������� �������")]
    public event AosEventHandler OnTeleportToObject;
    public void OnTeleportEnd()
    {
        OnTeleportToObject?.Invoke();
    }
    private void Start()
    {
        _door.AosTeleportEvent += OnTeleportEnd;
    }

}