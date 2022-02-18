using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour, IClickAble
{
    public UnityAction<Transform> TeleportToObjectEvent;
    public UnityAction AosTeleportEvent;

    [SerializeField] private Transform _newPlayerPosition;

    public void StartTeleporting()
    {
        TeleportToObjectEvent?.Invoke(_newPlayerPosition);
        AosTeleportEvent?.Invoke();
    }
    public void OnClicked()
    {
        StartTeleporting();
    }
}