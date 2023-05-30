using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ArrowMovement : MonoBehaviour
{
     public GameObject arrow;
       public float arrowPosition = -3.5f;
       public float arrowSpeed = 1f;
       public string sceneName = "empty";
       void Start()
       {
           Yoyoying();
       }
   
       private void Yoyoying()
       {
           if (sceneName == "street")
           {
               arrow.transform.DOMoveZ(arrowPosition, arrowSpeed).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
           }
           else if (sceneName == "supermarket")
           {
               arrow.transform.DOMoveY(arrowPosition, arrowSpeed).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
           }
           else
           {
               arrow.transform.DOMoveX(arrowPosition, arrowSpeed).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
           }
         
       }
}
