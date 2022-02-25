using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "Дверь из ДСП в коридор")]
public class FromDSPToCorridoorDoor : AosObjectBase
{
    [SerializeField] private Door _door;
    private void Start()
    {
        _door.AosTeleportEvent += OnTeleportEnd;
    }

    [AosAction(name: "Телепорт в коридор из ДСП метод")]
    public void StartTeleporting()
    {
        _door.StartTeleporting();
    }
    [AosEvent(name: "Телепорт в коридор из ДСП событие")]
    public event AosEventHandler OnTeleportToObject;
    private void OnTeleportEnd()
    {
        OnTeleportToObject?.Invoke();
    }

}