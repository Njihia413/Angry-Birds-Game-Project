using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit_Application : MonoBehaviour
{
    // This function is called when the Quit button is pressed
    public void QuitGame()
    {
        Debug.Log("Quitting the game."); // Optional: Log a message for debugging purposes

        Application.Quit();

        SceneManager.LoadScene(0);
    }
}
