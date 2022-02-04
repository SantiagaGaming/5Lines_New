using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ReleObjCanvas5Viev : MonoBehaviour
{
    public UnityAction<int> RepairButtonTapEvent;


    [SerializeField] private Button _repairButton1;
    [SerializeField] private Button _repairButton2;
    [SerializeField] private Button _repairButton3;
    [SerializeField] private Button _repairButton4;
    [SerializeField] private Button _repairButton5;
    [SerializeField] private Button _repairButton6;


    private void Start()
    {

        _repairButton1.onClick.AddListener(() => { RepairAndHide(0); });
        _repairButton2.onClick.AddListener(() => { RepairAndHide(1); });
        _repairButton3.onClick.AddListener(() => { RepairAndHide(2); });
        _repairButton4.onClick.AddListener(() => { RepairAndHide(3); });
        _repairButton5.onClick.AddListener(() => { RepairAndHide(4); });
        _repairButton6.onClick.AddListener(() => { RepairAndHide(5); });


    }
    private void RepairAndHide(int number)
    {
     
        RepairButtonTapEvent?.Invoke(number);
    }
}
