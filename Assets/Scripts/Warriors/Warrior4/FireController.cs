using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
   
    public GameObject parent;   

    void Update()
    {
        StartCoroutine(DestroyItem());
    }

    IEnumerator DestroyItem()
    {
        yield return new WaitForSeconds(5f);
        GameObject.Destroy(parent);
    }
}
