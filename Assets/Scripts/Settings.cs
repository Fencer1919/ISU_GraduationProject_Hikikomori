using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Toggle fullscreenTog;
    public Toggle vsyncTog;

    // Start is called before the first frame update
    void Start()
    {
        fullscreenTog.isOn = Screen.fullScreen;

        if (QualitySettings.vSyncCount == 0)
        {
            vsyncTog.isOn = false;
        }
        else 
        {
            vsyncTog.isOn = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyGraphics()
    {
        Screen.fullScreen = fullscreenTog.isOn;
        
        if (vsyncTog.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else 
        { 
            QualitySettings.vSyncCount = 0;
        }
    }
    
    //Set  Resolution Will Be Added
    /*
    public void SetResolution() 
    {
        Screen.SetResolution(1920, 1080, fullscreenTog);
    }
    */
}