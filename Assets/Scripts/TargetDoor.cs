using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDoor : MonoBehaviour
{
    public GameObject congratsPanel;

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
            if(PlayerController.isPlayerColoring)
            {
                Debug.Log("Player成功到达终点");
                Destroy(other.gameObject);
                congratsPanel.SetActive(true);
            }
        }
    }

}
