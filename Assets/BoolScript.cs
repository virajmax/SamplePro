using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolScript : MonoBehaviour
{
    public GameObject parent;
    void Awake()
    {
        switch (parent.name)
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
        //DescriptionScript.Name = "AC";
    }
}
