using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowVRHead : MonoBehaviour
{
    public Transform vrMainObject;
    public float cameraOffsetXZ;
    public float cameraOffsetY;
    public float bodyTurnAngle = 1f;
    public GameObject startStop;
    private Animator myAnim;
    private Vector3 vrRot, myRot;
    private Transform vrCamera;
    private float x, z;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        vrCamera = Camera.main.transform;

        
    }

    // Update is called once per frame
    void Update()
    {
        vrRot = vrCamera.rotation.eulerAngles;
        myRot = transform.rotation.eulerAngles;

        if(Mathf.DeltaAngle(vrRot.y, myRot.y) > bodyTurnAngle)
        {
            //Debug.Log("TURN LEFT");
            //myAnim.SetTrigger("TurnLeft");
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.y = rotationVector.y - 15;
            transform.rotation = Quaternion.Euler(rotationVector);
            //startStop.transform.rotation = Quaternion.Euler(rotationVector);

        }
        else if (Mathf.DeltaAngle(vrRot.y, myRot.y) <- bodyTurnAngle)
        {
           // Debug.Log("TURN RIGHT");
            //myAnim.SetTrigger("TurnLeft");
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.y = rotationVector.y + 15;
            transform.rotation = Quaternion.Euler(rotationVector);
            //startStop.transform.rotation = Quaternion.Euler(rotationVector);

        }
    }
}
