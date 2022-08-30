using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlatformManagement : MonoBehaviour
{

    

    public static float lastTimeHidden = 0;

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.tag.Equals("PlatformLimit") || !collision.gameObject.tag.Equals("Ground"))
        {
            MoveWithIn(collision, transform);
           
        }
        
    }

    

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (!collision.gameObject.tag.Equals("PlatformLimit") || !collision.gameObject.tag.Equals("Ground"))
        {
            MoveWithIn(collision, null);
            foreach (Transform child in transform)
            {
                child.gameObject.transform.SetParent(null);

            }
            gameObject.SetActive(false);
            lastTimeHidden = Time.time;
          

        }

    }

    

    private void MoveWithIn(Collision2D collision, Transform value)
    {
        collision.collider.transform.SetParent(value);
    }

    

}
