using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInterractNameViev : MonoBehaviour
{
    [SerializeField] private Text _interractText;
    public void ShowInterractText(string value)
    {
        _interractText.text = value;
    }
}
