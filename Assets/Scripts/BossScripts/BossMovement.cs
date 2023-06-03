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
        SoundManager.Instance.sceneCheck = "boss";
        Yoyoying();
        SpawnLaugh();
    }

    private void Yoyoying()
    {
        bossMouth.transform.DOMoveY(bossPosition, bossSpeed).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
    private void SpawnLaugh()
    {
        SoundManager.Instance.PlayBossSound(SoundManager.BossSoundTypes.Boss);
    }
}
