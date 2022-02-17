using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP6Animation : MonoBehaviour
{
    private Animator _anim;
    private void Start()
    {
        _anim = GetComponent<Animator>();

    }
    public void PlayRightOKAnimation()
    {
        _anim.SetTrigger("FromLeftToRightOk");
    }
    public void PlayLeftOKAnimation()
    {
        _anim.SetTrigger("FromRightToLeftOk");
    }
    public void PlayRightBrokenAnimation()
    {
        _anim.SetTrigger("FromLeftToRightBroken");
        print("broken");
    }
    public void PlayLeftBrokenAnimation()
    {
        _anim.SetTrigger("FromRightToLeftBroken");
        print("broken");
    }
}
