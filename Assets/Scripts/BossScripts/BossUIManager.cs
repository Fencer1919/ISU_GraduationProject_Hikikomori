using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossUIManager : MonoBehaviour
{ 
    public GameObject bossCompletedPanel;
    public GameObject timerPanel;
    public string nextSceneName;
    public Countdown countdown;
    public string bossSceneCheck = "-";

    public PlayerBossMovement playerBossMovement;


    public void FixedUpdate()
    {
        if (countdown.currentTime == 0)
        {
            OnBossSuccess();
        }
    }
    public void OnBossSuccess()
    {
    if(bossSceneCheck == "boss")
    {
        playerBossMovement.StopMovement();
        timerPanel.SetActive(false);
        SoundManager.Instance.sceneCheck = "normal";
        SoundManager.Instance.OnSceneChanged();
        SceneManager.LoadScene(nextSceneName);
    }
    else
    {
        playerBossMovement.StopMovement();
        bossCompletedPanel.SetActive(true);
        timerPanel.SetActive(false);
        SoundManager.Instance.sceneCheck = "normal";
        SoundManager.Instance.OnSceneChanged();
    }
       
    }
}
