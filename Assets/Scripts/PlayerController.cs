using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool isPlayerColoring;
    public static bool moveRight;
    public float speed;
    public float distanceToGo;
    public float coldTime;

    private float time;
    private Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        isPlayerColoring = false;
        moveRight = true;
        time = coldTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            nextPos = transform.position + new Vector3(distanceToGo, 0, 0);
            transform.position = Vector2.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            nextPos = transform.position + new Vector3(-distanceToGo, 0, 0);
            transform.position = Vector2.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, nextPos) < 0.1f)
        {
            if (coldTime > 0)
            {
                coldTime -= Time.deltaTime;
            }
            else
            {
                coldTime = time;
            }
        }
    }
}
