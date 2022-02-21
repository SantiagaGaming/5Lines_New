using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampDsp : MonoBehaviour
{
    [SerializeField] private Color _color;

    public void ChangeColor()
    {
        GetComponent<Renderer>().material.color = _color;
    }
   public void ResetColor()
    {
        GetComponent<Renderer>().material.color = Color.white;

    }
}
