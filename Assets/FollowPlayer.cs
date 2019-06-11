using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // public Transform player;
    // public Vector3 offset;
    
    private float y;


    // Use this for initialization
    void Start()
    {
        //offset = transform.position - player.transform.position;
        //x = transform.position.x;
        y = transform.position.y;
        Debug.Log("Y:" + y);

    }
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
       // transform.position = fake.transform.position;
    }

    void LateUpdate()
    {

       // transform.position = player.position + offset;
    }
}
