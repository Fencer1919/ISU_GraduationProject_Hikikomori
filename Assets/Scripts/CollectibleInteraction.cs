using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleInteraction : MonoBehaviour
{
    public UIManager uiManager;
    public GameObject collectibleInteract;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(transform.position, collectibleInteract.transform.position) < 2f)
            {
                uiManager.OpenLetter();
            }
        }
    }
}