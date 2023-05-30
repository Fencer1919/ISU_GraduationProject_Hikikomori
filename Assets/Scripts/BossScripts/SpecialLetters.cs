using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpecialLetters : MonoBehaviour
{
    public LetterBossMovement letterBossMovement;
    float randValue = Random.value;
    
    public List<GameObject> specialLetters;

    public float highChance = .2f;
    public float midChance = .05f;
    public float lowChance = .03f;

    public string bossLevel = "one";
    

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(WaitForSpawn());
    }

    IEnumerator WaitForSpawn()
    {
        while (true)
        {
            SpawnSpecialLettersForTheFirstTime();
            yield return new WaitForSeconds(letterBossMovement.waitingSpeed);
        }
    }

    public void SpawnSpecialLettersForTheFirstTime()
    {
        
        randValue = Random.value;

        if (bossLevel == "two")
        {
            HighChance();
        } 
        
        else if (bossLevel == "three")
        {
            MidChance();
        } 
        
        else if(bossLevel == "four")
        {
            LowChance();
        }
    }
    public void SpawnSpecialLetters()
    {
        int spawnPointNumber = Random.Range(0,6);
        int letterNumber = Random.Range(0,5);
        
        Instantiate(specialLetters[letterNumber],letterBossMovement.spawnPositions[spawnPointNumber].transform.position,Quaternion.Euler(0f,90f,0f));
    }

    public void HighChance()
    {
        if (randValue < highChance) 
        {
            SpawnSpecialLetters();
        }
        
    }
    
    public void MidChance()
    {
       if (randValue < midChance)
       {
            SpawnSpecialLetters(); 
       }
        
    }
    
    public void LowChance()
    {
        if (randValue < lowChance) 
        {
            SpawnSpecialLetters();
        }
    }

  
}
