using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrap3 : MonoBehaviour
{
    public GameObject block1; //横着
    public GameObject block2; //横着
    public GameObject block3; //竖着
    public GameObject block4; //竖着
    public GameObject block5; //竖着

    // Start is called before the first frame update
    void Start()
    {
        block1.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block1.GetComponent<Collider2D>().enabled = false;

        block3.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block3.GetComponent<Collider2D>().enabled = false;

        block5.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block5.GetComponent<Collider2D>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CircleCollider2D")
        {
            if (GameManger.TrapFlag)
            {
                GameManger.TrapFlag = false;
                EnableBlocks();
            }
            else
            {
                GameManger.TrapFlag = true;
                DisableBlocks();
            }

        }

        if (other.CompareTag("Enemy") && other.GetType().ToString() == "UnityEngine.CircleCollider2D")
        {
            if (GameManger.TrapFlag)
            {
                GameManger.TrapFlag = false;
                EnableBlocks();
            }
            else
            {
                GameManger.TrapFlag = true;
                DisableBlocks();
            }

        }
    }

    void EnableBlocks()
    {
        block1.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block1.GetComponent<Collider2D>().enabled = true;
        block2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block2.GetComponent<Collider2D>().enabled = false;
        block3.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block3.GetComponent<Collider2D>().enabled = true;
        block4.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block4.GetComponent<Collider2D>().enabled = false;
        block5.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block5.GetComponent<Collider2D>().enabled = true;
    }

    void DisableBlocks()
    {
        block1.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block1.GetComponent<Collider2D>().enabled = false;
        block2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block2.GetComponent<Collider2D>().enabled = true;
        block3.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block3.GetComponent<Collider2D>().enabled = false;
        block4.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block4.GetComponent<Collider2D>().enabled = true;
        block5.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block5.GetComponent<Collider2D>().enabled = false;
    }
}
