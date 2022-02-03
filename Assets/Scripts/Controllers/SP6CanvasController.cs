using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP6CanvasController : MonoBehaviour
{
    [SerializeField] private SP6CanvasViev _sp6CanvasViev;
    [SerializeField] private ShupController _shupController;

    private void OnEnable()
    {
        _sp6CanvasViev.ButtonTapEvent += SetShupPosition;

    }
    private void OnDisable()
    {
        _sp6CanvasViev.ButtonTapEvent -= SetShupPosition;
    }
    private void SetShupPosition(Transform position, string text)
    {
        _shupController.SetShupPosition(position, text);
    }
}
