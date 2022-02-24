using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _minutesTimer;
    private float _secondsTimer;
    private bool _timecontrol;
    private void Start()
    {
        _timecontrol = true;
    }
    private void Update()
    {
        if(_timecontrol)
        {
            _secondsTimer += Time.deltaTime;
            TimeChanger();
            ReturnTime();
        }
    }
    private void TimeChanger()
    {
        if(_secondsTimer>59)
        {
            _minutesTimer++;
            _secondsTimer = 0;
        }
    }
    public string ReturnTime()
    {
        return string.Format("{0:00}:{1:00}", _minutesTimer, _secondsTimer);
    }
    public void ControlTime(bool value)
    {
        _timecontrol = value;
    }
}
