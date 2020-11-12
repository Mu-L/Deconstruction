using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{
    public static bool isRoomCollided; //检测两个房间之间是否发生碰撞

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
            //如果两个房间没有发生碰撞
            if(!isRoomCollided)
            {
                PlayerController.moveRight = !PlayerController.moveRight;
            }
        }
    }
}
