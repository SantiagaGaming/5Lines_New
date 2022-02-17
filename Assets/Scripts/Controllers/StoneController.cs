using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour
{
    [SerializeField] private GameObject _stoneLeft;
    [SerializeField] private GameObject _stoneRight;

    public bool CheckStones()
    {
        if (!_stoneLeft.activeSelf && !_stoneRight.activeSelf)
        {
            return true;
        }
        else return false;
    }

}
