using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour {

    public GameObject pauseMenu;

    public void Start() {
        pauseMenu.SetActive(false);
    }

    public void MainMenu () {
        SceneManager.LoadScene("MainMenu");
    }

    public void PauseMenu () {
        pauseMenu.SetActive(true);
              
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);

    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
        }
    }

}
