using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ArrowMovement : MonoBehaviour
{
     public GameObject arrowMouth;
       public float arrowPosition = -3.5f;
       public float arrowSpeed = 1f;
       void Start()
       {
           Yoyoying();
       }
   
       private void Yoyoying()
       {
           arrowMouth.transform.DOMoveX(arrowPosition, arrowSpeed).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
       }
}
