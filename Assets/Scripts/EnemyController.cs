using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static bool isEnemyActive;
    public static bool moveRight;
    public float speed;
    public Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        isEnemyActive = false;
        moveRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isEnemyActive)
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
        }
    }
}
