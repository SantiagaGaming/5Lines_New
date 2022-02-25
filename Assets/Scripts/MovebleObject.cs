using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;


public class MovebleObject : MonoBehaviour
{
    [SerializeField] protected GameObject _moveObjButton;
    [SerializeField] protected bool _condition;
    [SerializeField] protected bool _yPoz;
    public virtual void RepairObject()
    {
        StartCoroutine(Move());
    }
    private IEnumerator Move()
    { int x = 0;
        _moveObjButton.SetActive(false);
        _condition = true;
        while (x<=16)
        {
            if(!_yPoz)
           transform.position += new Vector3(0.025f, 0, 0);
            else
                transform.position += new Vector3(0, 0.025f, 0);
            yield return new WaitForSeconds(0.05f);
            x++;
        }
        while(x>0)
        {
            if (!_yPoz)
                transform.position -= new Vector3(0.025f, 0, 0);
            else
                transform.position -= new Vector3(0, 0.025f, 0);
            yield return new WaitForSeconds(0.05f);
            x--;
        }
        _moveObjButton.SetActive(true);
    }
    public bool GetCondition()
    {
        return _condition;
    }
    public void SetCondition(bool value)
    {
        _condition = value;
    }
}
