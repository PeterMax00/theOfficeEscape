using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStopPlayerFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 _cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = target.position + _cameraOffset;
        transform.position = newPos;
    }
}
