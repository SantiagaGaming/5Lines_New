using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;

[AosObject(name: "Дверь с коридора в ДСП")]
public class FromCorridorToDspDoor : AosObjectBase
{
    [SerializeField] private Door _door;

    [AosAction(name: "Телепорт в ДСП из коридора метод")]
    public void StartTeleporting()
    {
        _door.StartTeleporting();
    }

    [AosEvent(name: "Телепорт в ДСП из коридора событие")]
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