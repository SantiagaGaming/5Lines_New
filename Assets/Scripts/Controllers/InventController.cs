using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventController : MonoBehaviour
{
    [SerializeField] private InventoryViev _inventoryViev;
    [SerializeField] private SoundPlayer _soundPlayer;
    private GameCanvasViev _currentCanvasViev;
    private bool _showedMap = false;
   
    private void OnEnable()
    {
        _inventoryViev.MapButtonTapEvent += OnMapShow;
        _inventoryViev.MeasureButtonTapEvent += OnMeasureButtonShow;
    }
    private void OnDisable()
    {
        _inventoryViev.MapButtonTapEvent -= OnMapShow;
        _inventoryViev.MeasureButtonTapEvent -= OnMeasureButtonShow;
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
    private void OnMeasureButtonShow()
    {
        _currentCanvasViev.ShowMeasureButtons();
    }
    public void SetCurrentCanvas(GameCanvasViev canvasViev)
    {
        _currentCanvasViev = canvasViev;
    }
}
