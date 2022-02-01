using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DspBackCanvasController : MonoBehaviour
{
    [SerializeField] private DspBackCanvasViev _dspBackCanvasViev;
    [SerializeField] private ShupController _shupController;
    private bool _firstmeasure = false;
    private void OnEnable()
    {
        _dspBackCanvasViev.Z_402ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_403ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_404ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_405ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_406ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_501ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_502ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_503ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_504ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_505ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_506ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_507ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_508ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_509ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_510ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_511ButtonTapEvent += SetShupPosition;
        _dspBackCanvasViev.Z_512ButtonTapEvent += SetShupPosition;


    }
    private void OnDisable()
    {
        _dspBackCanvasViev.Z_402ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_403ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_404ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_405ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_406ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_501ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_502ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_503ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_504ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_505ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_506ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_507ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_508ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_509ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_510ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_511ButtonTapEvent -= SetShupPosition;
        _dspBackCanvasViev.Z_512ButtonTapEvent -= SetShupPosition;
    }
    private void SetShupPosition(Transform position)
    {
        if(!_firstmeasure)
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
