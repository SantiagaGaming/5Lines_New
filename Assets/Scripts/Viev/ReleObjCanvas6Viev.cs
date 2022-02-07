using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ReleObjCanvas6Viev : MonoBehaviour
{
    public UnityAction<int> RepairButtonTapEvent;
    public UnityAction<int> WatchButtonTapEvent;

    [SerializeField] private Button _repairButton1;
    [SerializeField] private Button _repairButton2;
    [SerializeField] private Button _repairButton3;
    [SerializeField] private Button _repairButton4;
    [SerializeField] private Button _repairButton5;

    [SerializeField] private Button _watchButton1;
    [SerializeField] private Button _watchButton2;
    [SerializeField] private Button _watchButton3;
    [SerializeField] private Button _watchButton4;
    [SerializeField] private Button _watchButton5;



    private void Start()
    {

        _repairButton1.onClick.AddListener(() => { RepairAndHide(0); });
        _repairButton2.onClick.AddListener(() => { RepairAndHide(1); });
        _repairButton3.onClick.AddListener(() => { RepairAndHide(2); });
        _repairButton4.onClick.AddListener(() => { RepairAndHide(3); });
        _repairButton5.onClick.AddListener(() => { RepairAndHide(4); });


        _watchButton1.onClick.AddListener(() => { WatchButtonTapEvent?.Invoke(0); });
        _watchButton2.onClick.AddListener(() => { WatchButtonTapEvent?.Invoke(1); });
        _watchButton3.onClick.AddListener(() => { WatchButtonTapEvent?.Invoke(2); });
        _watchButton4.onClick.AddListener(() => { WatchButtonTapEvent?.Invoke(3); });
        _watchButton5.onClick.AddListener(() => { WatchButtonTapEvent?.Invoke(4); });


    }
    private void RepairAndHide(int number)
    {
        RepairButtonTapEvent?.Invoke(number);
    }
}
