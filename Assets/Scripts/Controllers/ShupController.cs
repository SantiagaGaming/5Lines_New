using System.Collections;
using System.Collections.Generic;
using AosSdk.Core.Scripts;
using UnityEngine;
using UnityEngine.Events;

public class ShupController : MonoBehaviour
{
    public UnityAction<string> SetMeasureTextEvent;

    [SerializeField] private GameObject _redShup;
    [SerializeField] private GameObject _blackShup;

    private bool _firstMeasure = false;
    private string _measureText;
 
    public void SetShupPosition(Transform newPos, string text)
    {
        if (!_firstMeasure)
        {
            if (_redShup.transform.position != newPos.position && _blackShup.transform.position != newPos.position)
            {
                _redShup.transform.position = newPos.position;
                _firstMeasure = true;
                _measureText = text;
                SetMeasureTextEvent?.Invoke(_measureText);
            }
        }
        else if (_firstMeasure)
        {
            if (_redShup.transform.position != newPos.position && _blackShup.transform.position != newPos.position)
            {
                _blackShup.transform.position = newPos.position;
                _firstMeasure = false;
                _measureText += " " + text;
                SetMeasureTextEvent?.Invoke(_measureText);
            }
        }

    }
}
