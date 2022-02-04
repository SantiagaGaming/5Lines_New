using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInteractNameController : MonoBehaviour
{
    [SerializeField] private GameObject _getInteractNameViev;
    [SerializeField] private GetInterractNameViev _viev;
    [SerializeField] private SwitchCameraObject[] _interactObjects;

    private void Start()
    {
        foreach (var switchCameraObject in _interactObjects)
        {
            switchCameraObject.GetNameOfObjectEvent += OnSetInterractText;
        }
    }
    private void OnSetInterractText(string value)
    {
        if (value == "")
            _getInteractNameViev.SetActive(false);
        else
        {
            _getInteractNameViev.SetActive(true);
            _viev.ShowInterractText(value);
        }
    }
}
