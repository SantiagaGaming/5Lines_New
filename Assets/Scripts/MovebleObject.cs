using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;

[AosObject(name: "Двигающийся объект")]
public class MovebleObject : AosObjectBase
{
    [SerializeField] private GameObject _moveObjButton;
    [SerializeField] private bool _condition;

    [AosEvent(name: "Смена состояния объекта")]
    public event AosEventHandler OnRepairObject;

    [AosAction(name: "Починить Объект")]
    public void RepairNmsh()
    {
        StartCoroutine(Move());
    }
    private IEnumerator Move()
    { int x = 0;
        OnRepairObject?.Invoke();
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
