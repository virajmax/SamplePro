using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class SnapShotCamera : MonoBehaviour
{
    Camera snapCam;

    int resWidth = 256;
    int resHeight = 256;
    void Awake()
    {
        snapCam = GetComponent<Camera>();
        if (snapCam.targetTexture == null)
        {
            snapCam.targetTexture = new RenderTexture(resWidth, resHeight, 24);
        }
        else
        {
            resWidth = snapCam.targetTexture.width;
            resHeight = snapCam.targetTexture.height;
        }
        Debug.Log(resWidth + "........." + resHeight);
        snapCam.gameObject.SetActive(false);
    }


    public void TakeSnapShot()
    {
        snapCam.gameObject.SetActive(true);
    }

    void LateUpdate()
    {
        if (snapCam.gameObject.activeInHierarchy)
        {
            Texture2D snapShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
            snapCam.Render();
            RenderTexture.active = snapCam.targetTexture;
            snapShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
            byte[] bytes = snapShot.EncodeToPNG();
            string fileName = SnapShotName();
            System.IO.File.WriteAllBytes(fileName, bytes);
            Debug.Log("Snapshot is taken");
            snapCam.gameObject.SetActive(false);
        }
    }

    string SnapShotName()
    {
        return string.Format("{0}/SnapShots/snap_{1}x{2}_{3}.png",
            Application.dataPath,
            resWidth,
            resHeight,
            System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")
            );
    }
}
