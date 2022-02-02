using System.Collections;
using System.Collections.Generic;
using AosSdk.Core.Scripts;
using UnityEngine;

public class ShupController : MonoBehaviour
{
    [SerializeField] private GameObject _redShup;
    [SerializeField] private GameObject _blackShup;
    private bool _firstMeasure = false;
 
    public void SetShupPosition(Transform newPos)
    {
        if (!_firstMeasure)
        {
            if (_redShup.transform.position != newPos.position && _blackShup.transform.position != newPos.position)
            {
                _redShup.transform.position = newPos.position;
                _firstMeasure = true;
            }
      

        }
        else if (_firstMeasure)
        {
            if (_redShup.transform.position != newPos.position && _blackShup.transform.position != newPos.position)
            {
                _blackShup.transform.position = newPos.position;
                _firstMeasure = false;
            }

        }

    }
}
