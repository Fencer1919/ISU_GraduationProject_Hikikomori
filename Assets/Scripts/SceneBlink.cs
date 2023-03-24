using System.Collections;
using System.Collections. Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class SceneBlink : MonoBehaviour
{ 
    public Image imageToFade;
    public float fadeDuration = 0.2f;
    public string nextSceneName;
    public bool isCollided = false;
    
    public SceneTransition sceneTransition;
    
    public Image blinkingImage; // The Light You Want To Flicker.
    public float MinTime; // Minimum value that the timer can have.
    public float MaxTime; // Maximum value that the timer can have.
    public float Timer; // T
    

    void Start()
    {
        Timer = Random.Range(MinTime, MaxTime);
    }

    void Update()
    {
        if(isCollided == true)
        {
            BlinkingText();
            //imageToFade.DOFade(1, fadeDuration).onComplete += onComplete;
        }
    }
    
    private void onComplete()
    {
       sceneTransition.OnComplete();
    }

    void BlinkingText()
    {
        onComplete();
        if (Timer > 0)
            Timer -= Time.deltaTime; // Start decreasing the timer if the timer is bigger than 0.

        if (Timer <= 0)
        {
            blinkingImage.enabled =
                !blinkingImage.enabled; // If timer is less than 0 start flickering.If the light is enable, disable it otherwise enable it. 
            Timer = Random.Range(MinTime, MaxTime); // Reset the timer to loop the flickering.
        }
    }
}