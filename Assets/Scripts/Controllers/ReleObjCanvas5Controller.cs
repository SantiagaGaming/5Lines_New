using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleObjCanvas5Controller : MonoBehaviour
{
    [SerializeField] private ReleObjCanvas5Viev _viev;
    [SerializeField] private NmshBfk[] _nmshBfks;

    private void OnEnable()
    {
        _viev.RepairButtonTapEvent += OnChangeNmshBfk;
    }
    private void OnDisable()
    {
        _viev.RepairButtonTapEvent -= OnChangeNmshBfk;
    }
    private void OnChangeNmshBfk(int number)
    {
        _nmshBfks[number].RepairNmsh();
    }
}
