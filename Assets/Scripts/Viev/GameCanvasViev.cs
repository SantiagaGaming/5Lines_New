using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvasViev : MonoBehaviour
{
    [SerializeField] private GameObject _measureButtons;
    [SerializeField] private GameObject _repairButtons;

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
    public void HideAllButtons()
    {
        _measureButtons.SetActive(false);
        _repairButtons.SetActive(false);
    }
}
