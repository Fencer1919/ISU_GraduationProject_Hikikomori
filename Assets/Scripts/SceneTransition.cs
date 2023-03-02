using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Image imageToFade;
    public float fadeDuration = 1.0f;
    public float targetAlpha = 0.0f;
    public string nextSceneName;

    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeOutAndLoadScene());
        }
    }

    private IEnumerator FadeOutAndLoadScene()
    {
        Color originalColor = imageToFade.color;
        Color targetColor = new Color(originalColor.r, originalColor.g, originalColor.b, targetAlpha);
        float currentTime = 0.0f;

        while (currentTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(originalColor.a, targetAlpha, currentTime / fadeDuration);
            imageToFade.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            currentTime += Time.deltaTime;
            yield return null;
        }

        imageToFade.color = targetColor;
        SceneManager.LoadScene(nextSceneName);
    }
}