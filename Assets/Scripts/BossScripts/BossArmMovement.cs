using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BossArmMovement : MonoBehaviour
{
    public GameObject bossLeftArm;
    public GameObject bossRightArm;
    // Start is called before the first frame update
    void Start()
    {
        YoyoyingLeft();
        YoyoyingRight();
        SpawnLaugh();

    }

    private void YoyoyingLeft()
    {
        bossLeftArm.transform.DORotate(new Vector3(0f,0f,4.94f), 1f).SetLoops(-1, LoopType.Yoyo);
    }
    
    private void YoyoyingRight()
    {
        bossRightArm.transform.DORotate(new Vector3(0f,0f,-5.86f), 1f).SetLoops(-1, LoopType.Yoyo);
    }
        

    private void SpawnLaugh()
    {
        SoundManager.Instance.PlayBossSound(SoundManager.BossSoundTypes.Boss);
    }

}
