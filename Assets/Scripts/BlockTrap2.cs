using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrap2 : MonoBehaviour
{
    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject block4;

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
        if (other.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.PolygonCollider2D")
        {
            //启动三个Block
            block1.SetActive(false);
            block2.SetActive(false);
            block3.SetActive(false);
            block4.SetActive(false);
        }
    }
}
