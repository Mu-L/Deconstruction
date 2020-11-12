using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualTrigger : MonoBehaviour
{
    public GameObject block;

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
        block.SetActive(false);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        block.SetActive(true);
    }
}
