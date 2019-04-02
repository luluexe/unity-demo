using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenuController : MonoBehaviour {     

    public void Play () {
     SceneManager.LoadScene("Fase01");
    }    

    public void Quit () {        

    }

}