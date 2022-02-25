using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
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
    public void OnClicked(InteractHand interactHand)
    {
        StartTeleporting();
    }
    public bool IsHoverable { get; set; } = true;

    public bool IsClickable { get; set; } = true;
}
