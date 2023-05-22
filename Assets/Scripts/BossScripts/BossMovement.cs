using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BossMovement : MonoBehaviour
{
    public GameObject bossMouth;
    public float bossPosition = -3.5f;
    public float bossSpeed = 1f;
    void Start()
    {
        Yoyoying();
    }

    private void Yoyoying()
    {
        bossMouth.transform.DOMoveY(bossPosition, bossSpeed).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
