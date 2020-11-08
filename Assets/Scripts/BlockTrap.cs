using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrap : MonoBehaviour
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
            block1.SetActive(true);
            block2.SetActive(true);
            block3.SetActive(true);
            block4.SetActive(true);
        }
    }
}
