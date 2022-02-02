using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP6CanvasController: MonoBehaviour
{
    [SerializeField] private SP6CanvasViev _sp6CanvasViev;
    [SerializeField] private ShupController _shupController;
    private void OnEnable()
    {
        _sp6CanvasViev.ButtonTap1Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap2Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap3Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap4Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap5Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap6Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap7Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap8Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap9Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap10Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap11Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap12Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap13Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap14Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap15Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap16Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap17Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap18Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap19Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap20Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap21Event += SetShupPosition;
        _sp6CanvasViev.ButtonTap22Event += SetShupPosition;


    }
    private void OnDisable()
    {
        _sp6CanvasViev.ButtonTap1Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap2Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap3Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap4Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap5Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap6Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap7Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap8Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap9Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap10Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap11Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap12Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap13Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap14Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap15Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap16Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap17Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap18Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap19Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap20Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap21Event -= SetShupPosition;
        _sp6CanvasViev.ButtonTap22Event -= SetShupPosition;
    }
    private void SetShupPosition(Transform position)
    {
            _shupController.SetShupPosition(position);
    }
}
