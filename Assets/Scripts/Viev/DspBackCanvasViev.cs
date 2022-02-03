using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DspBackCanvasViev : MonoBehaviour
{
    public UnityAction<Transform, string> ButtonTapEvent;

    [SerializeField] private Button[] _buttons;
    private void Start()
    {
        foreach (var Button in _buttons)
        {
            Button.onClick.AddListener(() => { ButtonTapEvent?.Invoke(Button.GetComponent<Transform>(), Button.name); });

        }
    }

}