using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "Дверь с коридора на улицу")]
public class FromCorridorToStreetDoor : AosObjectBase
{
    [SerializeField] private Door _door;
    private void Start()
    {
        _door.AosTeleportEvent += OnTeleportEnd;
    }

    [AosAction(name: "Телепорт на улицу из коридора метод")]
    public void StartTeleporting()
    {
        _door.StartTeleporting();
    }

    [AosEvent(name: "Телепорт на улицу из коридора событие")]
    public event AosEventHandler OnTeleportToObject;
    private void OnTeleportEnd()
    {
        OnTeleportToObject?.Invoke();
    }

}