using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BossMovement : MonoBehaviour
{
    public GameObject bossMouth;
    void FixedUpdate()
    {
        Yoyoying();
    }

    private void Yoyoying()
    {
        bossMouth.transform.DOMoveY(-3.5f, 1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
