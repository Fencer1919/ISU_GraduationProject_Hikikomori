using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LetterBossMovement : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> letters;
    public List<GameObject> spawnPositions;
    
    public float speed = 4f;

    
    void Start()
    {
        StartCoroutine(WaitForSpawn());
    }
    
    IEnumerator WaitForSpawn()
    {
        while (true)
        { 
            SpawnLetters();
            yield return new WaitForSeconds(speed);
        }
        
    }

    public void SpawnLetters()
    {
        int spawnPointNumber = Random.Range(0,3);
        int letterNumber = Random.Range(0,8);
        
        Instantiate(letters[letterNumber],spawnPositions[spawnPointNumber].transform.position,Quaternion.Euler(0f,90f,0f));
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Letter"))
        {
            Debug.Log("Crashed");
            //TODO UI Manager
        }
    }
}
