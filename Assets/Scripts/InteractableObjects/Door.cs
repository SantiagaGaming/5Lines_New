using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;

[AosObject(name: "Дверь")]
public class Door : AosObjectBase, IClickAble
{
    public UnityAction<Transform> TeleportToObjectEvent;

    [SerializeField] private Transform _newPlayerPosition;

    [AosEvent(name: "Телепорт к объекту событие")]
    public event AosEventHandler OnTeleportToObject;

    [AosAction(name: "Телепорт к объекту")]
    public void StartTeleporting()
    {
        Debug.Log("teleport");
        TeleportToObjectEvent?.Invoke(_newPlayerPosition);
        OnTeleportToObject?.Invoke();
    }
    public void OnClicked()
    {
        StartTeleporting();
    }
}