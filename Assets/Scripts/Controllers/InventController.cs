using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventController : MonoBehaviour
{
    [SerializeField] private InventoryViev _inventoryViev;
    [SerializeField] private SoundPlayer _soundPlayer;
    [SerializeField] private ShupController _shupController;
    private GameCanvasViev _currentCanvasViev;
    private bool _showedMap = false;
   
    private void OnEnable()
    {
        _inventoryViev.MapButtonTapEvent += OnMapShow;
        _inventoryViev.MeasureButtonTapEvent += OnMeasureButtonShow;
        _shupController.SetMeasureTextEvent += OnSetMeasureText;
        _inventoryViev.BackButtonTapEvent += OnHideAllWindows;
        _inventoryViev.RepairButtonTapEvent += OnRepaiButtonShow;
    }
    private void OnDisable()
    {
        _inventoryViev.MapButtonTapEvent -= OnMapShow;
        _inventoryViev.MeasureButtonTapEvent -= OnMeasureButtonShow;
        _shupController.SetMeasureTextEvent -= OnSetMeasureText;
        _inventoryViev.BackButtonTapEvent -= OnHideAllWindows;
        _inventoryViev.RepairButtonTapEvent -= OnRepaiButtonShow;

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
    private void OnRepaiButtonShow()
    {
        _currentCanvasViev.ShowRepairButtons();
    }
    public void SetCurrentCanvas(GameCanvasViev canvasViev)
    {
        _currentCanvasViev = canvasViev;
    }
    private void OnSetMeasureText(string text)
    {
        _inventoryViev.ShowMeasureTextWindow(true);
        _inventoryViev.ShowMeasureText(text);
    }
    private void OnHideAllWindows()
    {
        _inventoryViev.ShowMeasureTextWindow(false);
        _currentCanvasViev.HideAllButtons();
    }
}
