using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Main Menu
    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnSettingsButtonClick()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void OnQuitButtonClick()
    {
#if !UNITY_EDITOR
        Application.Quit();
#else
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    //Settings
    public void OnBackButtonClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}