using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventController : MonoBehaviour
{
    [SerializeField] private InventoryViev _inventoryViev;
    [SerializeField] private SoundPlayer _soundPlayer;
    [SerializeField] private ShupController _shupController;
    [SerializeField] private Strelka _strelka;
    [SerializeField] private ReleObjCanvas5Controller _releObjCanvas5Controller;
    [SerializeField] private ReleObjCanvas6Controller _releObjCanvas6Controller;

    private GameCanvasViev _currentCanvasViev;

    private bool _showedMap = false;
   
    private void OnEnable()
    {
        _inventoryViev.MapButtonTapEvent += OnMapShow;
        _inventoryViev.MeasureButtonTapEvent += OnMeasureButtonShow;
        _shupController.SetMeasureTextEvent += OnSetMeasureText;
        _inventoryViev.BackButtonTapEvent += OnHideAllWindows;
        _inventoryViev.RepairButtonTapEvent += OnRepaiButtonShow;
        _inventoryViev.RadioButtonTapEvent +=OnRadioButtonShow;
        _inventoryViev.RepairButtonTapEvent += OnRepaiButtonShow;
        _inventoryViev.TouchButtonTapEvent += OnTouchButtonShow;
        _inventoryViev.WatchButtonTapEvent += OnWatchButtonShow;
        _strelka.GetStrelkaCondition += OnShowStrelkaCondition;
        _releObjCanvas5Controller.NmshConditionEvent += OnShowNmshCondition;
        _releObjCanvas6Controller.ObjConditionEvent += OnShowNmshCondition;
    }
    private void OnDisable()
    {
        _inventoryViev.MapButtonTapEvent -= OnMapShow;
        _inventoryViev.MeasureButtonTapEvent -= OnMeasureButtonShow;
        _shupController.SetMeasureTextEvent -= OnSetMeasureText;
        _inventoryViev.BackButtonTapEvent -= OnHideAllWindows;
        _inventoryViev.RepairButtonTapEvent -= OnRepaiButtonShow;
        _inventoryViev.RadioButtonTapEvent -= OnRadioButtonShow;
        _inventoryViev.RepairButtonTapEvent -= OnRepaiButtonShow;
        _inventoryViev.TouchButtonTapEvent -= OnTouchButtonShow;
        _inventoryViev.WatchButtonTapEvent -= OnWatchButtonShow;
        _strelka.GetStrelkaCondition -= OnShowStrelkaCondition;
        _releObjCanvas5Controller.NmshConditionEvent -= OnShowNmshCondition;
        _releObjCanvas6Controller.ObjConditionEvent -= OnShowNmshCondition;
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
    private void OnWatchButtonShow()
    {
        _currentCanvasViev.ShowWatchButtons();
    }
    private void OnRadioButtonShow()
    {
        _soundPlayer.PlayRadioSound();
        _currentCanvasViev.ShowRadioButtons();
    }
    private void OnTouchButtonShow()
    {
        _currentCanvasViev.ShowTouchButtons();
    }
    public void SetCurrentCanvas(GameCanvasViev canvasViev)
    {
        _currentCanvasViev = canvasViev;
    }
    private void OnSetMeasureText(string text)
    {
        _inventoryViev.ShowMessageWindow(true);
        _inventoryViev.ShowMeasureText(text);
    }
    private void OnHideAllWindows()
    {
        _inventoryViev.ShowMessageWindow(false);
        _currentCanvasViev.HideAllButtons();
        _shupController.ResetShupPosition();
    }
    private void OnShowNmshCondition(bool value)
    {
        SetMessageWindowText(value, "Исправен", "Не Исправен");
    }
    private void OnShowStrelkaCondition(bool value)
    {
        SetMessageWindowText(value, "Стрелка переведена в состояние +", "Стрелка переведена в состояние -");
    }
    private void SetMessageWindowText(bool value, string truth, string lie)
    {
        _inventoryViev.ShowMessageWindow(true);
        if (value)
        {
            _inventoryViev.ShowMeasureText(truth);
        }
        else
        {
            _inventoryViev.ShowMeasureText(lie);
        }
    }
}
