using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleObjCanvas2Controller : MonoBehaviour
{
    [SerializeField] private ReleObjCanvas2Viev _viev;
    [SerializeField] private ShupController _shupController;

   
    private void OnEnable()
    {
        _viev.MeasureButtonTapEvent += SetShupPosition;

    }
    private void OnDisable()
    {
        _viev.MeasureButtonTapEvent -= SetShupPosition;
    }
    private void SetShupPosition(Transform position, string text)
    {
        _shupController.SetShupPosition(position, text);
    }
}
