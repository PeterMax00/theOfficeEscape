using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour
{
    public float speed = 10.0f;
    public  bool moveTest;
    // Start is called before the first frame update
    void Start()
    {
        moveTest = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Camera.main.transform.rotation.y);
       if(transform.position.y < 0.25)
        {
            moveTest = false;
        }
        

        if (moveTest)
            transform.Translate(Vector3.forward * Time.deltaTime);
        /* float translation = Input.GetAxis("Vertical") * speed;
         float strffe = Input.GetAxis("Horizontal") * speed;
         translation *= Time.deltaTime;
         straffe *= Time.deltaTime;

         transform.Translate(straffe, 0, translation);

         if (Input.GetKeyDown("escape"))
             Cursor.lockState = CursorLockMode.None;
             */
    }
        
  

    public void Gaze()
    {
        if (moveTest == false)
        {
            moveTest = true;

        }
        else
        {
            moveTest = false;
        }
    }
}
