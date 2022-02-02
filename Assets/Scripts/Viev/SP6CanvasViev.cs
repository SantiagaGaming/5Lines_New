using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SP6CanvasViev : MonoBehaviour
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
    public UnityAction<Transform> ButtonTap11Event;
    public UnityAction<Transform> ButtonTap12Event;
    public UnityAction<Transform> ButtonTap13Event;
    public UnityAction<Transform> ButtonTap14Event;
    public UnityAction<Transform> ButtonTap15Event;
    public UnityAction<Transform> ButtonTap16Event;
    public UnityAction<Transform> ButtonTap17Event;
    public UnityAction<Transform> ButtonTap18Event;
    public UnityAction<Transform> ButtonTap19Event;

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
    [SerializeField] private Button _11Button;
    [SerializeField] private Button _12Button;
    [SerializeField] private Button _13Button;
    [SerializeField] private Button _14Button;
    [SerializeField] private Button _15Button;
    [SerializeField] private Button _16Button;
    [SerializeField] private Button _17Button;
    [SerializeField] private Button _18Button;
    [SerializeField] private Button _19Button;
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
        _11Button.onClick.AddListener(() => { ButtonTap11Event?.Invoke(_11Button.GetComponent<Transform>()); });
        _12Button.onClick.AddListener(() => { ButtonTap12Event?.Invoke(_12Button.GetComponent<Transform>()); });
        _13Button.onClick.AddListener(() => { ButtonTap13Event?.Invoke(_13Button.GetComponent<Transform>()); });
        _14Button.onClick.AddListener(() => { ButtonTap14Event?.Invoke(_14Button.GetComponent<Transform>()); });
        _15Button.onClick.AddListener(() => { ButtonTap15Event?.Invoke(_15Button.GetComponent<Transform>()); });
        _16Button.onClick.AddListener(() => { ButtonTap16Event?.Invoke(_16Button.GetComponent<Transform>()); });
        _17Button.onClick.AddListener(() => { ButtonTap17Event?.Invoke(_17Button.GetComponent<Transform>()); });
        _18Button.onClick.AddListener(() => { ButtonTap18Event?.Invoke(_18Button.GetComponent<Transform>()); });
        _19Button.onClick.AddListener(() => { ButtonTap19Event?.Invoke(_19Button.GetComponent<Transform>()); });

    }

}

