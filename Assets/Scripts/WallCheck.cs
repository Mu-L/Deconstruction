using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{
    public static bool isRight;

    private static int i;
    private bool isInNewRoom;
    // Start is called before the first frame update
    void Start()
    {
        isRight = true;
        i = 0;
        isInNewRoom = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //isRight = !isRight;
        if (!isInNewRoom)
        {
            isRight = !isRight;
        }
        else
        {
            isRight = true;
            isInNewRoom = false;
        }

        Debug.Log("Player离开了房间");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(i > 0)
        {
            if (other.gameObject.CompareTag("Room"))
            {
                Debug.Log("Player进入了房间");

                isInNewRoom = true;
            }
        }
        i++;
    }
}
