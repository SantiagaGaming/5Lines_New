using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UMP24CanvasViev : MonoBehaviour
{
    public UnityAction<Transform> ButtonTap1Event;
    public UnityAction<Transform> ButtonTap2Event;
    public UnityAction<Transform> ButtonTap3Event;
    public UnityAction<Transform> ButtonTap4Event;
    public UnityAction<Transform> ButtonTap5Event;
    public UnityAction<Transform> ButtonTap6Event;
    public UnityAction<Transform> ButtonTap7Event;
    public UnityAction<Transform> ButtonTap8Event;
    public UnityAction<Transform> ButtonTap9Event;
    public UnityAction<Transform> ButtonTap10Event;


    [SerializeField] private Button _1Button;
    [SerializeField] private Button _2Button;
    [SerializeField] private Button _3Button;
    [SerializeField] private Button _4Button;
    [SerializeField] private Button _5Button;
    [SerializeField] private Button _6Button;
    [SerializeField] private Button _7Button;
    [SerializeField] private Button _8Button;
    [SerializeField] private Button _9Button;
    [SerializeField] private Button _10Button;

    private void Start()
    {
        _1Button.onClick.AddListener(() => { ButtonTap1Event?.Invoke(_1Button.GetComponent<Transform>()); });
        _2Button.onClick.AddListener(() => { ButtonTap2Event?.Invoke(_2Button.GetComponent<Transform>()); });
        _3Button.onClick.AddListener(() => { ButtonTap3Event?.Invoke(_3Button.GetComponent<Transform>()); });
        _4Button.onClick.AddListener(() => { ButtonTap4Event?.Invoke(_4Button.GetComponent<Transform>()); });
        _5Button.onClick.AddListener(() => { ButtonTap5Event?.Invoke(_5Button.GetComponent<Transform>()); });
        _6Button.onClick.AddListener(() => { ButtonTap6Event?.Invoke(_6Button.GetComponent<Transform>()); });
        _7Button.onClick.AddListener(() => { ButtonTap7Event?.Invoke(_7Button.GetComponent<Transform>()); });
        _8Button.onClick.AddListener(() => { ButtonTap8Event?.Invoke(_8Button.GetComponent<Transform>()); });
        _9Button.onClick.AddListener(() => { ButtonTap9Event?.Invoke(_9Button.GetComponent<Transform>()); });
        _10Button.onClick.AddListener(() => { ButtonTap10Event?.Invoke(_10Button.GetComponent<Transform>()); });


    }

}

