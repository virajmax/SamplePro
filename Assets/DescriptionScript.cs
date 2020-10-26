using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionScript : MonoBehaviour
{

    public static bool objectCaptured;
    public static string Name;
    public GameObject description;

    // Start is called before the first frame update
    void Start()
    {
        objectCaptured = false;
        GetComponent<GameObject>().SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (Name)
        {
            case "AC":
                Debug.Log("AC");
                break;
            case "AC2":
                Debug.Log("AC2");
                break;
            case "ACBH":
                Debug.Log("ACBH");
                break;
            case "ACR":
                Debug.Log("ACR");
                break;
            case "AC3":
                Debug.Log("AC3");
                break;
            case "ACBF":
                Debug.Log("ACBF");

                break;
            case "ACRO":
                Debug.Log("ACRO");
                break;
            case "ACU":
                Debug.Log("ACU");
                break;
            case "ACS":
                Debug.Log("ACS");
                break;
            case "ACO":
                Debug.Log("ACO");
                break;
        }
    }
}
