using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UMP24CanvasController : MonoBehaviour
{
    [SerializeField] private UMP24CanvasViev _ump24CanvasViev;
    [SerializeField] private ShupController _shupController;

    private void OnEnable()
    {
        _ump24CanvasViev.ButtonTapEvent += SetShupPosition;
     
    }
    private void OnDisable()
    {
        _ump24CanvasViev.ButtonTapEvent -= SetShupPosition;
    }
    private void SetShupPosition(Transform position, string text)
    {
            _shupController.SetShupPosition(position, text);
    }
}
