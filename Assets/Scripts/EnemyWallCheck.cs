using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWallCheck : MonoBehaviour
{
    public GameObject retryGamePanel;
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
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CircleCollider2D")
        {
            Destroy(other.gameObject);
            retryGamePanel.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Room"))
        {
            if (!isRoomCollided)
            {
                EnemyController.moveRight = !EnemyController.moveRight;
            }
        }
    }
}
