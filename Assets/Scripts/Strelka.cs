using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Strelka : MonoBehaviour
{
    public UnityAction <bool> GetStrelkaCondition;

    [SerializeField] private StoneController _stoneController;
    [SerializeField] private RailsAnimation _sp6Anim;

    private bool _condition;
    public void SetCondition(bool value)
    {
        if (_stoneController.CheckStones())
        {
            _condition = value;
            GetStrelkaCondition?.Invoke(_condition);
            if (!value)
                _sp6Anim.PlayLeftOKAnimation();
            else
                _sp6Anim.PlayRightOKAnimation();

        }
        else if (_condition)
            _sp6Anim.PlayLeftBrokenAnimation();
        else if (!_condition)
            _sp6Anim.PlayRightBrokenAnimation();
    
    }
    public bool GetCondition()
    {
        return _condition;
    }
}
