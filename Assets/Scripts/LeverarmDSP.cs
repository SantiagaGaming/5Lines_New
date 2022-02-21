using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverarmDSP : MonoBehaviour
{
    private Animator _anim;
    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    public void Rotate(int direction)
    {
        if (direction == 0)
            _anim.SetTrigger("Left");
        else if (direction == 1)
            _anim.SetTrigger("Right");
        else _anim.SetTrigger("Idle");
    }


}
