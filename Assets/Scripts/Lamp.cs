using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private Color _defaultColor;

    public void ChangeColor()
    {
        GetComponent<Renderer>().material.color = _color;
    }
   public void ResetColor()
    {
        GetComponent<Renderer>().material.color = _defaultColor;

    }
}
