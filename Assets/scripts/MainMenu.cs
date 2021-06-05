using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        Debug.Log("New gameee yeeeeee ama hala buradasın neden");
    }
    public void Credits()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Debug.Log("Exit!");
        Application.Quit();
    }
}
