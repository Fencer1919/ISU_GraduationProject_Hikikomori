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
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (Vector3.Distance(transform.position, objectToInteract.transform.position) < 0.5f)
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }

    }
}