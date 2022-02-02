using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DspBackCanvasViev : MonoBehaviour
{
    public UnityAction<Transform, string> Z_402ButtonTapEvent;
    public UnityAction<Transform, string> Z_403ButtonTapEvent;
    public UnityAction<Transform, string> Z_404ButtonTapEvent;
    public UnityAction<Transform, string> Z_405ButtonTapEvent;
    public UnityAction<Transform, string> Z_406ButtonTapEvent;
    public UnityAction<Transform, string> Z_501ButtonTapEvent;
    public UnityAction<Transform, string> Z_502ButtonTapEvent;
    public UnityAction<Transform, string> Z_503ButtonTapEvent;
    public UnityAction<Transform, string> Z_504ButtonTapEvent;
    public UnityAction<Transform, string> Z_505ButtonTapEvent;
    public UnityAction<Transform, string> Z_506ButtonTapEvent;
    public UnityAction<Transform, string> Z_507ButtonTapEvent;
    public UnityAction<Transform, string> Z_508ButtonTapEvent;
    public UnityAction<Transform, string> Z_509ButtonTapEvent;
    public UnityAction<Transform, string> Z_510ButtonTapEvent;
    public UnityAction<Transform, string> Z_511ButtonTapEvent;
    public UnityAction<Transform, string> Z_512ButtonTapEvent;

    [SerializeField] private Button _z_402Button;
    [SerializeField] private Button _z_403Button;
    [SerializeField] private Button _z_404Button;
    [SerializeField] private Button _z_405Button;
    [SerializeField] private Button _z_406Button;
    [SerializeField] private Button _z_501Button;
    [SerializeField] private Button _z_502Button;
    [SerializeField] private Button _z_503Button;
    [SerializeField] private Button _z_504Button;
    [SerializeField] private Button _z_505Button;
    [SerializeField] private Button _z_506Button;
    [SerializeField] private Button _z_507Button;
    [SerializeField] private Button _z_508Button;
    [SerializeField] private Button _z_509Button;
    [SerializeField] private Button _z_510Button;
    [SerializeField] private Button _z_511Button;
    [SerializeField] private Button _z_512Button;
    private void Start()
    {
        _z_402Button.onClick.AddListener(() => { Z_402ButtonTapEvent?.Invoke(_z_402Button.GetComponent<Transform>(),_z_402Button.name); });
        _z_403Button.onClick.AddListener(() => { Z_403ButtonTapEvent?.Invoke(_z_403Button.GetComponent<Transform>(), _z_403Button.name); });
        _z_404Button.onClick.AddListener(() => { Z_404ButtonTapEvent?.Invoke(_z_404Button.GetComponent<Transform>(), _z_404Button.name); });
        _z_405Button.onClick.AddListener(() => { Z_405ButtonTapEvent?.Invoke(_z_405Button.GetComponent<Transform>(), _z_405Button.name); });
        _z_406Button.onClick.AddListener(() => { Z_406ButtonTapEvent?.Invoke(_z_406Button.GetComponent<Transform>(), _z_406Button.name); });
        _z_501Button.onClick.AddListener(() => { Z_501ButtonTapEvent?.Invoke(_z_501Button.GetComponent<Transform>(), _z_501Button.name); });
        _z_502Button.onClick.AddListener(() => { Z_502ButtonTapEvent?.Invoke(_z_502Button.GetComponent<Transform>(), _z_502Button.name); });
        _z_503Button.onClick.AddListener(() => { Z_503ButtonTapEvent?.Invoke(_z_503Button.GetComponent<Transform>(), _z_503Button.name); });
        _z_504Button.onClick.AddListener(() => { Z_504ButtonTapEvent?.Invoke(_z_504Button.GetComponent<Transform>(), _z_504Button.name); });
        _z_505Button.onClick.AddListener(() => { Z_505ButtonTapEvent?.Invoke(_z_505Button.GetComponent<Transform>(), _z_505Button.name); });
        _z_506Button.onClick.AddListener(() => { Z_506ButtonTapEvent?.Invoke(_z_506Button.GetComponent<Transform>(), _z_506Button.name); });
        _z_507Button.onClick.AddListener(() => { Z_507ButtonTapEvent?.Invoke(_z_507Button.GetComponent<Transform>(), _z_507Button.name); });
        _z_508Button.onClick.AddListener(() => { Z_508ButtonTapEvent?.Invoke(_z_508Button.GetComponent<Transform>(), _z_508Button.name); });
        _z_509Button.onClick.AddListener(() => { Z_509ButtonTapEvent?.Invoke(_z_509Button.GetComponent<Transform>(), _z_509Button.name); });
        _z_510Button.onClick.AddListener(() => { Z_510ButtonTapEvent?.Invoke(_z_510Button.GetComponent<Transform>(), _z_510Button.name); });
        _z_511Button.onClick.AddListener(() => { Z_511ButtonTapEvent?.Invoke(_z_511Button.GetComponent<Transform>(), _z_511Button.name); });
        _z_512Button.onClick.AddListener(() => { Z_512ButtonTapEvent?.Invoke(_z_512Button.GetComponent<Transform>(), _z_512Button.name); });

    }

}
