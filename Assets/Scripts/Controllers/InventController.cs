using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventController : MonoBehaviour
{
    [SerializeField] private InventoryViev _inventoryViev;
    [SerializeField] private SoundPlayer _soundPlayer;
    private bool _showedMap = false;
    private void OnEnable()
    {
        _inventoryViev.MapButtonTapEvent += OnMapShow;
    }
    private void OnDisable()
    {
        _inventoryViev.MapButtonTapEvent -= OnMapShow;
    }
    private void OnMapShow()
    {
        if(!_showedMap)
        {
            _inventoryViev.ShowMap(true);
            _showedMap = true;
            _soundPlayer.PlayMapOpenSound();
        }
        else
        {
            _inventoryViev.ShowMap(false);
            _showedMap = false;
            _soundPlayer.PlayMapCloseSound();
        }

    }
}
