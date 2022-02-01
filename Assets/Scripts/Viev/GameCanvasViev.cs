using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvasViev : MonoBehaviour
{
    [SerializeField] private GameObject _measureButtons;

    public void ShowMeasureButtons()
    {
        _measureButtons.SetActive(true);
    }
}
