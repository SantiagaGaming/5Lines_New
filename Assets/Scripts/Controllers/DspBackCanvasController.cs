using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DspBackCanvasController : MonoBehaviour
{
    [SerializeField] private DspBackCanvasViev _dspBackCanvasViev;
    [SerializeField] private ShupController _shupController;

    private void OnEnable()
    {
        _dspBackCanvasViev.ButtonTapEvent += SetShupPosition;

    }
    private void OnDisable()
    {
        _dspBackCanvasViev.ButtonTapEvent -= SetShupPosition;
    }
    private void SetShupPosition(Transform position, string text)
    {
        _shupController.SetShupPosition(position, text);
    }
}
