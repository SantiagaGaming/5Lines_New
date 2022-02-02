using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UMP24CanvasController : MonoBehaviour
{
    [SerializeField] private UMP24CanvasViev _ump24CanvasViev;
    [SerializeField] private ShupController _shupController;
    private bool _firstmeasure = false;
    private void OnEnable()
    {
        _ump24CanvasViev.ButtonTap1Event += SetShupPosition;
        _ump24CanvasViev.ButtonTap2Event += SetShupPosition;
        _ump24CanvasViev.ButtonTap3Event += SetShupPosition;
        _ump24CanvasViev.ButtonTap4Event += SetShupPosition;
        _ump24CanvasViev.ButtonTap5Event += SetShupPosition;
        _ump24CanvasViev.ButtonTap6Event += SetShupPosition;
        _ump24CanvasViev.ButtonTap7Event += SetShupPosition;
        _ump24CanvasViev.ButtonTap8Event += SetShupPosition;
        _ump24CanvasViev.ButtonTap9Event += SetShupPosition;
  


    }
    private void OnDisable()
    {
        _ump24CanvasViev.ButtonTap1Event -= SetShupPosition;
        _ump24CanvasViev.ButtonTap2Event -= SetShupPosition;
        _ump24CanvasViev.ButtonTap3Event -= SetShupPosition;
        _ump24CanvasViev.ButtonTap4Event -= SetShupPosition;
        _ump24CanvasViev.ButtonTap5Event -= SetShupPosition;
        _ump24CanvasViev.ButtonTap6Event -= SetShupPosition;
        _ump24CanvasViev.ButtonTap7Event -= SetShupPosition;
        _ump24CanvasViev.ButtonTap8Event -= SetShupPosition;
        _ump24CanvasViev.ButtonTap9Event -= SetShupPosition;

    }
    private void SetShupPosition(Transform position)
    {
        if (!_firstmeasure)
        {
            _shupController.SetRedShupPosition(position);
            _firstmeasure = true;
        }
        else
        {
            _shupController.SetBlackShupPosition(position);
            _firstmeasure = false;
        }
    }
}