using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
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
        if (other.CompareTag("WallCheck"))
        {
            PlayerController.moveRight = !PlayerController.moveRight;
        }

        if (other.CompareTag("EnemyWallCheck"))
        {
            EnemyController.moveRight = !EnemyController.moveRight;
        }
    }
}
