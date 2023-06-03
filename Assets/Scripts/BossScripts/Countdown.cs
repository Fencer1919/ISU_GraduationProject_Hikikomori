using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField] private Image time;
    [SerializeField] private Text timeText;
    public float currentTime;
    [SerializeField] private float duration;
    void Start()
    {
        currentTime = duration;
        timeText.text = currentTime.ToString();
        StartCoroutine(CountdownTime());
    }

    private void Update()
    {
  
    }

    private IEnumerator CountdownTime () {
        while(currentTime >= 0) {
            time.fillAmount = Mathf.InverseLerp(0, duration, currentTime);
            timeText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        yield return null;
    }
    
}