using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;

[AosObject(name: "Дверь с коридора в реле")]
public class FromCorridorToReleDoor : AosObjectBase
{
    [SerializeField] private Door _door;

    private void Start()
    {
        _door.AosTeleportEvent += OnTeleportEnd;
    }
    [AosAction(name: "Телепорт в реле из коридора метод")]
    public void StartTeleporting()
    {
        _door.StartTeleporting();
    }
    [AosEvent(name: "Телепорт в реле из коридора событие")]
    public event AosEventHandler OnTeleportToObject;
    private void OnTeleportEnd()
    {
        OnTeleportToObject?.Invoke();
    }

}