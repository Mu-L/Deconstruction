using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedColoringDoor : MonoBehaviour
{
    public SpriteRenderer playerSpriteRD;
    public Sprite coloringSprite;

    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.BoxCollider2D")
        {
            if (i == 0) //保证只对Player染色一次
            {
                //修改Player颜色，使用蓝色精灵图
                playerSpriteRD.sprite = coloringSprite;
                //标记Player已经染色
                PlayerController.isPlayerRedColoring = true;
                Debug.Log("Player经过红色的门");
                i++;
            }
        }
    }
}
