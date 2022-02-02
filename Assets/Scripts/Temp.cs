using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AosSdk.Core.Player.Scripts;
public class Temp : MonoBehaviour
{
    private void Start()
    {
        Player.Instance.TeleportTo(transform);
    }

}
