using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETrigger : MonoBehaviour
{
    public GameObject letterPanel;

    private void OnTriggerEnter(Collider other)
    { 
        letterPanel.SetActive(true);
        Debug.Log("enter");
  
    }
    
    void OnTriggerExit(Collider other)
    {
        letterPanel.SetActive(false);
    }
}
