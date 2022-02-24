using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailsAnimation : MonoBehaviour
{
    private Animator _anim;
    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    public void PlayRightOKAnimation()
    {
        _anim.SetTrigger("RightOk");
    }
    public void PlayLeftOKAnimation()
    {
        _anim.SetTrigger("LeftOk");
    }
    public void PlayRightBrokenAnimation()
    {
        _anim.SetTrigger("RightBroken");
    }
    public void PlayLeftBrokenAnimation()
    {
        _anim.SetTrigger("LeftBroken");
    }
}
