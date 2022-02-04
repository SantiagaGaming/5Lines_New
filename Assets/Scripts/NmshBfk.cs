using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NmshBfk : MonoBehaviour
{
    [SerializeField] private GameObject _nmshBfkButton;
    public void RepairNmsh()
    {
    
        StartCoroutine(Move());
    }
    private IEnumerator Move()
    { int x = 0;
        _nmshBfkButton.SetActive(false);
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
        _nmshBfkButton.SetActive(true);
    }
}
