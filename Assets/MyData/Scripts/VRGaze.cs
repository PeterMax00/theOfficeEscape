using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class VRGaze : MonoBehaviour
{
    public Image imgGaze;

    public float totalTime = 1;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfRay = 10;
    private RaycastHit _hit;

    AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MovementTeleport.blockGaze)
        {
            if(!audioSrc.isPlaying)
              audioSrc.Play();
        }
        else
        {
            audioSrc.Stop();
        }

        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.5f));
        
        if(Physics.Raycast(ray,out _hit, distanceOfRay))
        {
            if((imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Teleport")) )
            {
                if(MovementTeleport.blockGaze == false)
                {
                    _hit.transform.gameObject.GetComponent<MovementTeleport>().MovePlayer();
                }
                
            }
        }
        
    }

    public void GVROn()
    {
        if(MovementTeleport.blockGaze == false)
        {
            gvrStatus = true;
        }
        
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }

   
}
