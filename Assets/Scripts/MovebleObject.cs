using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovebleObject : MonoBehaviour
{
    [SerializeField] private GameObject _moveObjButton;
    [SerializeField] private bool _condition;
    public void RepairNmsh()
    {
        StartCoroutine(Move());
    }
    private IEnumerator Move()
    { int x = 0;
        _moveObjButton.SetActive(false);
        _condition = true;
        while (x<=16)
        {
           transform.position += new Vector3(0.025f, 0, 0);
            yield return new WaitForSeconds(0.05f);
            x++;
        }
        while(x>0)
        {
            transform.position -= new Vector3(0.025f, 0, 0);
            yield return new WaitForSeconds(0.05f);
            x--;
        }
        _moveObjButton.SetActive(true);
    }
    public bool GetCondition()
    {
        return _condition;
    }
}
