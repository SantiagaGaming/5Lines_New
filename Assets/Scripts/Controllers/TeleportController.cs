using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Player;
using AosSdk.Core.Interfaces;
public class TeleportController : MonoBehaviour
{
    [SerializeField] private Door[] _doors;
    [SerializeField] private CameraFlash _cameraFlash;

    private void Awake()
    {
        foreach (var Door in _doors)
        {
            Door.TeleportToObjectEvent += OnStartTeleporting;
        }
    }
    private void OnStartTeleporting(Transform newPlayerPosition)
    {
        Player.Instance.TeleportTo(newPlayerPosition);
        _cameraFlash.CameraFlashStart();
    }
}
