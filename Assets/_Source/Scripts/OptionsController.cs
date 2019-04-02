using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsController : MonoBehaviour {
        
    //resolutions

    //1920 x 1080
    public void Resolution01 () {
        Screen.SetResolution (1920, 1080, true);
        }

        //1280 x 720
        public void Resolution02() {
            Screen.SetResolution(1280, 720, true);
            }

   
    //graphics

    public void Quality01 () {
        QualitySettings.SetQualityLevel(0, true);

    }

    public void Quality02()
    {
        QualitySettings.SetQualityLevel(5, true);

    }  

}
