using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SceneTransition : MonoBehaviour
{
    public Image imageToFade;

    public float fadeDuration = 0.2f;
    public string nextSceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            imageToFade.DOFade(1, fadeDuration).onComplete += onComplete;
        }
    }

    private void onComplete()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}