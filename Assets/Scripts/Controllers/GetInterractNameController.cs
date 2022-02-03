using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInterractNameController : MonoBehaviour
{
    [SerializeField] private GameObject _getInterractNameViev;
    [SerializeField] private GetInterractNameViev _viev;
    [SerializeField] private SwitchCameraObject[] _interractObjects;
    private void Start()
    {
        foreach (var switchCameraObject in _interractObjects)
        {
            switchCameraObject.GetNameOfObjectEvent += OnSetInterractText;
        }
    }
    private void OnSetInterractText(string value)
    {
        if (value == "")
            _getInterractNameViev.SetActive(false);
        else
        {
            _getInterractNameViev.SetActive(true);
            _viev.ShowInterractText(value);
        }
    }
}
