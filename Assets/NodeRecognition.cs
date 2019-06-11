using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeRecognition : MonoBehaviour
{
    private Vector3[] angles;
    private int index;
    private Vector3 centerAngle;

    // Start is called before the first frame update
    void Start()
    {
        
        angles = new Vector3[30];
        index = 0;
        centerAngle = Camera.main.transform.eulerAngles;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        angles[index] = Camera.main.transform.eulerAngles;
        index++;
        if(index == 30)
        {
            CheckMovement();
            ResetGesture();
            
        }
    }

    void CheckMovement()
    {
        bool up = false;
        bool down = false;

        for(int i = 0; i < 30; i++)
        {
            if((angles[i].x < 65.0f && angles[i].x > 55.0f) && !up)
            {
              //  Debug.Log("UP ACTIVE");
                up = true;
            }
          //  else if ((angles[i].x < 60.0f && angles[i].x > 45.0f) && !down)
          //  {
          //      Debug.Log("DOWN ACTIVE");
          //      down = true;
           // }
        }

      

        if(up)
        {
            //PLayer shook head up and down to say YES
         //   Debug.Log("YES");
            if (VRLookWalk.moveForward)
            {
              //  VRLookWalk.moveForward = false;

            }
            else
            {   
               // VRLookWalk.moveForward = true;
            }

        }
        else
        {
           // Debug.Log("NO MOVE");
        }

    }

    void ResetGesture()
    {
        angles = new Vector3[30];
        index = 0;
        centerAngle = Camera.main.transform.eulerAngles;
    }
}
