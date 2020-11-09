using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld;

    private Transform playerTransform;
    private Transform enemyTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemyTransform = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        isBeingHeld = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX,
                mousePos.y - startPosY, 0);

        }
    }

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Room"))
        {
            WallCheck.isRoomCollided = true;
            EnemyWallCheck.isRoomCollided = true;
            Debug.Log("两个Room发生碰撞");
        }

        if (other.gameObject.CompareTag("Player"))
        {
            playerTransform.parent = gameObject.transform;
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            enemyTransform.parent = gameObject.transform;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Room"))
        {
            WallCheck.isRoomCollided = false;
            EnemyWallCheck.isRoomCollided = false;
            Debug.Log("两个Room脱离碰撞");
        }
    }
}
