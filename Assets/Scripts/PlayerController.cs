using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public float speed;
    public float distanceToGo;
    public float coldTime;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        time = coldTime;
    }

    // Update is called once per frame
    void Update()
    {
        DeleteByDeltaTime();
    }

    void DeleteByDeltaTime()
    {
        if (coldTime > 0)
        {
            coldTime -= Time.deltaTime;
        }
        else
        {
            //do something
            //Vector3 newPos = transform.position + new Vector3(distanceToGo, 0, 0);
            if(WallCheck.isRight)
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                transform.position = transform.position + new Vector3(distanceToGo, 0, 0);
            }
            else
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                transform.position = transform.position + new Vector3(-distanceToGo, 0, 0);
            }
            
            coldTime = time;
        }
    }
}
