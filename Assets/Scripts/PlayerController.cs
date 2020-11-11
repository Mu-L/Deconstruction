using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool isPlayerRedColoring;
    public static bool isPlayerYellowColoring;

    public static bool isPlayerColoring;
    public static bool moveRight;
    public float speed;
    public Rigidbody2D rb2d;
    public Sprite coloringSprite;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        isPlayerRedColoring = false;
        isPlayerYellowColoring = false;
        isPlayerColoring = false;
        moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
        }

        if(isPlayerRedColoring && isPlayerYellowColoring)
        {
            if (i == 0)
            {
                isPlayerColoring = true;
                GetComponent<SpriteRenderer>().sprite = coloringSprite;
                i++;
            }
                
        }
    }
}
