using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour { 

    public GameObject options;
    public GameObject mainmenu;

    // Start is called before the first frame update
    void Start() {
        options.SetActive(false);
        mainmenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Play () {
        SceneManager.LoadScene("Fase01");
    }

    public void Options () {
        options.SetActive(true);
        mainmenu.SetActive(false);
    }

    public void Quit () {
        
    }

}
