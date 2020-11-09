using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    public GameObject gb1;
    public float time;

    private EdgeCollider2D edge2D;
    // Start is called before the first frame update
    void Start()
    {
        edge2D = gb1.GetComponent<EdgeCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CircleCollider2D")
        {
            edge2D.enabled = false;
        }

        if (other.CompareTag("Enemy") && other.GetType().ToString() == "UnityEngine.CircleCollider2D")
        {
            edge2D.enabled = false;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CircleCollider2D")
        {
            StartCoroutine(EnableBox2D(time));
        }

        if (other.CompareTag("Enemy") && other.GetType().ToString() == "UnityEngine.CircleCollider2D")
        {
            StartCoroutine(EnableBox2D(time));
        }
    }

    IEnumerator EnableBox2D(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        edge2D.enabled = true;
    }
}
