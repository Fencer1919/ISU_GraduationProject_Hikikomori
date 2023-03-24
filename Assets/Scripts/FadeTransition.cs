using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class FadeTransition : MonoBehaviour
{
    public Image imageToFade;

    public float fadeDuration = 0.2f;
    public string nextSceneName;
    public int fadeCount = 5; // number of times to fade in and out

    private int currentFadeCount = 0; // current number of times faded

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && currentFadeCount < fadeCount)
        {
            currentFadeCount++;
            imageToFade.DOFade(1, fadeDuration).onComplete += OnFadeOutComplete;
        }
    }

    private void OnFadeOutComplete()
    {
        imageToFade.DOFade(0, fadeDuration).onComplete += OnFadeInComplete;
    }

    private void OnFadeInComplete()
    {
        if (currentFadeCount < fadeCount)
        {
            imageToFade.DOFade(1, fadeDuration).onComplete += OnFadeOutComplete;
        }
        else
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}