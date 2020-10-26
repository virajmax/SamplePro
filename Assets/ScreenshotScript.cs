using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScreenshotScript : MonoBehaviour
{
    [SerializeField]
    private GameObject description;

    private bool isShowDes = false;

    private void Start()
    {
        description.SetActive(false);
    }
    public void ShowDescription()
    {
        isShowDes = !isShowDes;
        description.SetActive(isShowDes);
    }
}
