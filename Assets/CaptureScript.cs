using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureScript : MonoBehaviour
{
    public SnapShotCamera snapCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            snapCam.TakeSnapShot();
        }
    }
}
