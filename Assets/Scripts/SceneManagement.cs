using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public string nextLevel;
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
        SceneManager.LoadScene("Daichi'sRoom");
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
    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnBossButtonClick()
    {
        SceneManager.LoadScene(nextLevel);
    }
}