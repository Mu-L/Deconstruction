using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{
    public GameObject obj;
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
        if(other.CompareTag("TriggerPlatform"))
        {
            obj.SetActive(false);
            Debug.Log("两个Platform发生碰撞");
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("TriggerPlatform"))
        {
            obj.SetActive(true);
            Debug.Log("两个Platform离开碰撞");
        }
    }
}
