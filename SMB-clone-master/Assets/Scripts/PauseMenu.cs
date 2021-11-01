using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   
    // Start is called before the first frame update
    public GameObject pause_menu;
    bool paused = false;

   
    public void Resume()
    {
        Time.timeScale = 1;
        pause_menu.SetActive(false);
        paused = false;
    }

    public void ToMainMenu()
    {
        pause_menu.SetActive(false);
        paused = false;
        
        SceneManager.LoadScene(0);
    }
    public void QuitToDesktop()
    {
        Application.Quit();
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene("World 1-1");

    }



    // Update is called once per frame

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == true)
            {
                Time.timeScale = 1;
                pause_menu.SetActive(false);
                paused = false;
            }
            else
            {
                Time.timeScale = 0;
                pause_menu.SetActive(true);
                paused = true;
            }

        }
    }
}
