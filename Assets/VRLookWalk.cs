using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour
{

    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float toggleAngleStop = 70.0f;
    public float speed = 3.0f;
    public static bool moveForward;

    private CharacterController cc;

    // Use this for initialization
    void Start()
    {
        moveForward = false;
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(vrCamera.eulerAngles.x);
       if(moveForward == false)
        {
            if(vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
            {
              //  Debug.Log("MOVE");
                moveForward = true;
            }


        }
        


        if(moveForward == true)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);


            if (vrCamera.eulerAngles.x <= 5.0f && vrCamera.eulerAngles.x < 90.0f)
            {
              //  Debug.Log("STOP");
                moveForward = false;
            }



        }
      /*  if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
           
        }
        else
        {
            moveForward = false;
        }

        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }

    */
    }
}