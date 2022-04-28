using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
   
public void GoToMainMenu() { SceneManager.LoadScene(0); }
public void Restart() { SceneManager.LoadScene(1); }

    public void UnPauseTheGame()
    {

       gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void QuitGame() { Application.Quit(); }
}
