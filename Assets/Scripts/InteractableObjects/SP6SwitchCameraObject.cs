using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using UnityEngine.Events;
public class SP6SwitchCameraObject : SwitchCameraObject
{
    [SerializeField] private Animator _anim;
    [SerializeField] private GameObject _roof;
    [SerializeField] private InventoryViev _invetory;
    [SerializeField] private CameraSwitchContoller _cameraController;

    private bool _isAmimated = false;
    private void OnEnable()
    {
        _invetory.BackButtonTapEvent += OnCloseSp6;
    }

    private void OnDisable()
    {
        _invetory.BackButtonTapEvent -= OnCloseSp6;
    }

    public override void OnClicked()
    {
        StartCoroutine(PlaySp6Anim(true));
    }
    private void OnCloseSp6()
    {
        if (_cameraController.CompareObjects(this))
        StartCoroutine(PlaySp6Anim(false));
    }
    private IEnumerator PlaySp6Anim(bool value)
    {
        if(!_isAmimated)
        {
            _isAmimated = true;
            _anim.SetTrigger("kurbelOut");
            yield return new WaitForSeconds(GetAnimLenght());
            StartCoroutine(RoofRotator(value));
            _anim.SetTrigger("kurbelIn");
            yield return new WaitForSeconds(GetAnimLenght());
            if (value)
                base.OnClicked();
            _isAmimated = false;
        }
    }
    private IEnumerator RoofRotator(bool value)
    {
        if (value)
        {
            int z = 0;
            while (z <= 120)
            {
                _roof.transform.localRotation = Quaternion.Euler(0, 0, z);
                z++;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            int z = 120;
            while (z >= 0)
            {
                _roof.transform.localRotation = Quaternion.Euler(0, 0, z);
                z--;
                yield return new WaitForSeconds(0.01f);
            }
        }
    }
    private float GetAnimLenght()
    {
        AnimatorStateInfo info = _anim.GetCurrentAnimatorStateInfo(0);
      float animLenght = info.length;
        return animLenght;
    }
}
