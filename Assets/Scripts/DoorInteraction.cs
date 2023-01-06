using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    public GameObject objectToInteract;
    public string nextSceneName;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(transform.position, objectToInteract.transform.position) < 2f)
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}