using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossUIManager : MonoBehaviour
{ 
    public GameObject bossCompletedPanel;
    public GameObject timerPanel;
    public Countdown countdown;
    
      

    public void FixedUpdate()
    {
        if (countdown.currentTime == 0)
        {
            OnBossSuccess();
        }
    }
    public void OnBossSuccess()
    {
        bossCompletedPanel.SetActive(true);
        timerPanel.SetActive(false);
    }
}
