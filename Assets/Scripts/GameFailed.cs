using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFailed : MonoBehaviour
{
    public GameObject retryGamePanel;
    private int i = 0;

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
        if (other.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.BoxCollider2D")
        {
            if (i == 0) //保证只对Player染色一次
            {
                retryGamePanel.SetActive(true);
                i++;
            }
        }
    }
}
