using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject logo;
    public GameObject inforPanel;

    void Start()
    {
        mainMenu.SetActive(true);
        logo.SetActive(true);
        inforPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CaptureButtonPressed()
    {
        SceneManager.LoadScene(1);
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PressedInforButton()
    {
        mainMenu.SetActive(false);
        logo.SetActive(false);
        inforPanel.SetActive(true);
    }

    public void inforPanelClose()
    {
        mainMenu.SetActive(true);
        logo.SetActive(true);
        inforPanel.SetActive(false);
    }
}
