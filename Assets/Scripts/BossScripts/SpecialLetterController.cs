using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialLetterController : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Letter"))
        {
            Destroy(collision.gameObject);
        }
        else if (collision.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    
}
