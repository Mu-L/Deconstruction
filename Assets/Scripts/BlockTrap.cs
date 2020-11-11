using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrap : MonoBehaviour
{
    public GameObject block1; //竖着
    public GameObject block2; //竖着
    public GameObject block3; //竖着
    public GameObject block4; //横着
    public GameObject block5; //横着
    public GameObject block6; //竖着
    public GameObject block7; //竖着
    public GameObject block8; //横着
    public GameObject block9; //横着



    // Start is called before the first frame update
    void Start()
    {
        block1.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block1.GetComponent<Collider2D>().enabled = false;
        block2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block2.GetComponent<Collider2D>().enabled = false;
        block3.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block3.GetComponent<Collider2D>().enabled = false;
        block6.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block6.GetComponent<Collider2D>().enabled = false;
        block7.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block7.GetComponent<Collider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CircleCollider2D")
        {
            if(GameManger.TrapFlag)
            {
                GameManger.TrapFlag = false;
                //启动三个Block
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
                //启动三个Block
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
        block2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block2.GetComponent<Collider2D>().enabled = true;
        block3.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block3.GetComponent<Collider2D>().enabled = true;
        block4.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block4.GetComponent<Collider2D>().enabled = false;
        block5.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block5.GetComponent<Collider2D>().enabled = false;
        block6.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block6.GetComponent<Collider2D>().enabled = true;
        block7.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block7.GetComponent<Collider2D>().enabled = true;
        block8.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block8.GetComponent<Collider2D>().enabled = false;
        block9.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block9.GetComponent<Collider2D>().enabled = false;
        //block1.SetActive(true);
        //block2.SetActive(true);
        //block3.SetActive(true);
        //block4.SetActive(false);
        //block5.SetActive(false);
        //block6.SetActive(true);
        //block7.SetActive(true);
        //block8.SetActive(false);
        //block9.SetActive(false);

    }

    void DisableBlocks()
    {
        block1.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block1.GetComponent<Collider2D>().enabled = false;
        block2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block2.GetComponent<Collider2D>().enabled = false;
        block3.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block3.GetComponent<Collider2D>().enabled = false;
        block4.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block4.GetComponent<Collider2D>().enabled = true;
        block5.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block5.GetComponent<Collider2D>().enabled = true;
        block6.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block6.GetComponent<Collider2D>().enabled = false;
        block7.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        block7.GetComponent<Collider2D>().enabled = false;
        block8.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block8.GetComponent<Collider2D>().enabled = true;
        block9.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
        block9.GetComponent<Collider2D>().enabled = true;

        //block1.SetActive(false);
        //block2.SetActive(false);
        //block3.SetActive(false);
        //block4.SetActive(true);
        //block5.SetActive(true);
        //block6.SetActive(false);
        //block7.SetActive(false);
        //block8.SetActive(true);
        //block9.SetActive(true);
    }
}
