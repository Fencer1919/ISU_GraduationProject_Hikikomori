using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string nextSceneName;
    public float waitingTime = 5f;

    public void OnComplete()
    {
        StartCoroutine(WaitForScene());
    }

    IEnumerator WaitForScene()
    {
        yield return new WaitForSeconds(waitingTime);
        SceneManager.LoadScene(nextSceneName);
    }
}