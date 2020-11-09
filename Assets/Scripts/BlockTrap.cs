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
                block1.SetActive(true);
                block2.SetActive(true);
                block3.SetActive(true);
                block4.SetActive(false);
                block5.SetActive(false);
                block6.SetActive(true);
                block7.SetActive(true);
                block8.SetActive(false);
                block9.SetActive(false);
            }
            else
            {
                GameManger.TrapFlag = true;
                block1.SetActive(false);
                block2.SetActive(false);
                block3.SetActive(false);
                block4.SetActive(true);
                block5.SetActive(true);
                block6.SetActive(false);
                block7.SetActive(false);
                block8.SetActive(true);
                block9.SetActive(true);
            }
            
        }

        if (other.CompareTag("Enemy") && other.GetType().ToString() == "UnityEngine.CircleCollider2D")
        {
            if (GameManger.TrapFlag)
            {
                GameManger.TrapFlag = false;
                //启动三个Block
                block1.SetActive(true);
                block2.SetActive(true);
                block3.SetActive(true);
                block4.SetActive(false);
                block5.SetActive(false);
                block6.SetActive(true);
                block7.SetActive(true);
                block8.SetActive(false);
                block9.SetActive(false);
            }
            else
            {
                GameManger.TrapFlag = true;
                block1.SetActive(false);
                block2.SetActive(false);
                block3.SetActive(false);
                block4.SetActive(true);
                block5.SetActive(true);
                block6.SetActive(false);
                block7.SetActive(false);
                block8.SetActive(true);
                block9.SetActive(true);
            }

        }
    }
}
