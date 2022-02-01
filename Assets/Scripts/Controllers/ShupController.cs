using System.Collections;
using System.Collections.Generic;
using AosSdk.Core.Scripts;
using UnityEngine;

public class ShupController : MonoBehaviour
{
    [SerializeField] private GameObject _redShup;
    [SerializeField] private GameObject _blackShup;
 
    public void SetRedShupPosition(Transform newPos)
    {
        _redShup.transform.position = newPos.position;
    }
    public void SetBlackShupPosition(Transform newPos)
    {
        _blackShup.transform.position = newPos.position;
    }
}
