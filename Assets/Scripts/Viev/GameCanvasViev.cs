using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameCanvasViev : MonoBehaviour
{

    public UnityAction ButtonsHidedEvent;
    
    [SerializeField] private GameObject _measureButtons;
    [SerializeField] private GameObject _repairButtons;
    [SerializeField] private GameObject _watchButtonns;
    [SerializeField] private GameObject _touchButtons;
    [SerializeField] private GameObject _radioButtons;

    public void ShowMeasureButtons()
    {
        HideAllButtons();
        _measureButtons.SetActive(true);
    }
    public void ShowRepairButtons()
    {
        HideAllButtons();
       _repairButtons.SetActive(true);
    }
    public void ShowWatchButtons()
    {
        HideAllButtons();
        _watchButtonns.SetActive(true);
    }
    public void ShowTouchButtons()
    {
        HideAllButtons();
        _touchButtons.SetActive(true);
    }
    public void ShowRadioButtons()
    {
        HideAllButtons();
        _radioButtons.SetActive(true);
    }
    public void HideAllButtons()
    {
        _measureButtons.SetActive(false);
        _repairButtons.SetActive(false);
        _watchButtonns.SetActive(false);
        _radioButtons.SetActive(false);
        _touchButtons.SetActive(false);
        ButtonsHidedEvent?.Invoke();
    }
}
