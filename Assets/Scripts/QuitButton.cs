using System.Collections;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    private bool isVisible = false;
    private float delayTime = 15f;

    // Reference to the coroutine handler GameObject
    private GameObject coroutineHandler;

    // Start is called before the first frame update
    void Start()
    {
        // Hide the button initially
        gameObject.SetActive(false);

        // Create a new GameObject to handle the coroutine
        coroutineHandler = new GameObject("CoroutineHandler");
        coroutineHandler.AddComponent<CoroutineHandler>().StartCoroutine(ShowButtonAfterDelay(delayTime));
    }

    private IEnumerator ShowButtonAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Show the button and set it as visible
        gameObject.SetActive(true);
        isVisible = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void OnDisable()
    {
        // Destroy the coroutine handler GameObject when this script is disabled
        Destroy(coroutineHandler);
    }
}

// MonoBehaviour to handle coroutines
public class CoroutineHandler : MonoBehaviour { }
