using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPlatforms : MonoBehaviour
{
    public float cooldown;
    public Vector3 velocity;

    void FixedUpdate()
    {

        foreach (Transform child in transform)
        {
            child.gameObject.transform.position += velocity * Time.deltaTime;

            if (!child.gameObject.activeSelf)
            {
                if (Time.time - AirPlatformManagement.lastTimeHidden > cooldown)
                {
                    child.gameObject.SetActive(true);
                    
                   
                }


            }
          
        }
    }
}
