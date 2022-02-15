using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using UnityEngine.Events;
public class SP6SwitchCameraObject : SwitchCameraObject
{
    [SerializeField] private Animator _anim;


    public override void OnClicked()
    {
        base.OnClicked();
        PlaySP6Anim();
    }
    private void PlaySP6Anim()
    {
        _anim.SetTrigger("kurbelOut");
    }


}
