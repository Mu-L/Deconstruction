using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{
    public static bool isRoomCollided;

    // Start is called before the first frame update
    void Start()
    {
        isRoomCollided = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Room"))
        {
            if(!isRoomCollided)
            {
                PlayerController.moveRight = !PlayerController.moveRight;
            }
        }
    }
}
