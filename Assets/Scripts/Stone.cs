using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    [SerializeField] private bool _rightStone;

    [SerializeField] private SoundPlayer _soundPlayer;
    [SerializeField] private GameObject _stone;
    [SerializeField] private RailCanvasViev _railCanvasViev;

    private void OnEnable()
    {
        if(_rightStone)
        _railCanvasViev.TouchButtonRightTapEvent += OnDisableStone;
        else
            _railCanvasViev.TouchButtonLeftTapEvent += OnDisableStone;

    }
    private void OnDisable()
    {
        if (_rightStone)
            _railCanvasViev.TouchButtonRightTapEvent -= OnDisableStone;
        else
            _railCanvasViev.TouchButtonLeftTapEvent -= OnDisableStone;
    }
    private void OnDisableStone()
    {
        if(_stone.activeSelf)
        {
            _stone.SetActive(false);
            _soundPlayer.PlayStoneSound();
        }
    }
    public bool GetStoneCondition()
    {
        if (_stone.activeSelf)
        {
            return true;
        }
        else return false;
    }
    public void EnableStone(bool value)
    {
        _stone.SetActive(value);
    }
}
