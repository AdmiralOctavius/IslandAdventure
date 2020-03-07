using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCode : MonoBehaviour
{
    // The sub-menus.
    public Canvas titleMenu;
    public Canvas tutorialMenu;

    // This is if play button is clicked (starts the game).
    public void playGame()
    {
        // Change the scene name for the actual scene.
        SceneManager.LoadSceneAsync("CollinTestScene");
    }
    // This is if how to play button is clicked (toggles the 
    // tutorial screen).
    public void toggleTutorial()
    {
        if (tutorialMenu.gameObject.activeSelf)
        {
            tutorialMenu.gameObject.SetActive(false);
            titleMenu.gameObject.SetActive(true);
        }
        else
        {
            tutorialMenu.gameObject.SetActive(true);
            titleMenu.gameObject.SetActive(false);
        }
    }
    // This is if quit button is clicked (quits the game).
    public void quitGame()
    {
        Application.Quit();
    }
}
