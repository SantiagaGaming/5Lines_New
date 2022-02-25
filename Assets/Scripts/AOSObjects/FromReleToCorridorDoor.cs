using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "Дверь из реле в коридор")]
public class FromReleToCorridorDoor : AosObjectBase
{
    [SerializeField] private Door _door;

    private void Start()
    {
        _door.AosTeleportEvent += OnTeleportEnd;
    }

    [AosAction(name: "Телепорт в коридор из реле метод")]
    public void StartTeleporting()
    {
        _door.StartTeleporting();
    }

    [AosEvent(name: "Телепорт в коридор из реле событие")]
    public event AosEventHandler OnTeleportToObject;
    private void OnTeleportEnd()
    {
        OnTeleportToObject?.Invoke();
    }

}