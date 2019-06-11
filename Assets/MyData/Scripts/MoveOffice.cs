using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffice : MonoBehaviour
{
    public GameObject player;
    Vector3 targetPosition;
    public bool move;

    public static bool blockGaze;
    public float movementSpeed = 5;



    void Start()
    {

        move = false;
        blockGaze = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {

            blockGaze = true;
            //player.transform.position = Vector3.Lerp(player.transform.position, targetPosition, movementSpeed * Time.deltaTime);
            player.transform.position = Vector3.MoveTowards(player.transform.position, targetPosition, Time.deltaTime * movementSpeed);
        }


        float differenceX = Mathf.Abs(player.transform.position.x - targetPosition.x);
        float differenceZ = Mathf.Abs(player.transform.position.z - targetPosition.z);
        float differenceY = Mathf.Abs(player.transform.position.y - targetPosition.y);

        if (differenceX < 0.3 && differenceY < 0.3 && differenceZ < 0.3 && move == true)
        {

            move = false;
            blockGaze = false;

        }


    }

    public void MovePlayer()
    {
        move = true;
        targetPosition = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);

    }
}
