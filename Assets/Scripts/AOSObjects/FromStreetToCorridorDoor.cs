using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "Дверь с улицы в коридор")]
public class FromStreetToCorridorDoor : AosObjectBase
{
    [SerializeField] private Door _door;
    private void Start()
    {
        _door.AosTeleportEvent += OnTeleportEnd;
    }

    [AosAction(name: "Телепорт в коридор с улицы метод")]
    public void StartTeleporting()
    {
        _door.StartTeleporting();
    }

    [AosEvent(name: "Телепорт в коридор с улицы событие")]
    public event AosEventHandler OnTeleportToObject;
    private void OnTeleportEnd()
    {
        OnTeleportToObject?.Invoke();
    }

}