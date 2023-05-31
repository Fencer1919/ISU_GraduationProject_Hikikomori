using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class PlayerBossMovement : MonoBehaviour
{
    [SerializeField]
    public GameObject mainPosition;
    public GameObject leftPosition;
    public GameObject rightPosition;

    public bool leftPos = false;
    public bool rightPos = false;
    
    public GameObject player;
    public Animator playerAnimator;
    public Rigidbody playerRb;
    public BoxCollider playerCollider;
    
    public SceneManagement sceneManagement;
    public Countdown countdown;

    public float specialLetterTimeDecrease = 30f;

    public bool isGameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = player.GetComponentInChildren<Rigidbody>();
        playerAnimator = player.GetComponentInChildren<Animator>();
        isGameStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameStarted)
        {
            ButtonChecking();
        }
        
    }
 
    public void ButtonChecking()
    {
        if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightTaskOnClick();
        }
        
        if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftTaskOnClick();
        }
    }
    public void RightTaskOnClick()
    {
   
        if (playerAnimator == null)
        {
            playerAnimator = player.GetComponentInChildren<Animator>();
        }

        if (playerAnimator)
        {
            playerAnimator.SetTrigger("isJumping");
        }

        if (rightPos == false)
        {
            transform.DOMove(rightPosition.gameObject.transform.position, 1f);
        }
        if(rightPos == true)
        {
            transform.DOMove(mainPosition.gameObject.transform.position, 1f);
            rightPos = false;
        }
        
        //SoundManager.Instance.PlaySound(SoundManager.SoundTypes.Jump);
        

    }
    
    public void LeftTaskOnClick()
    {
   
        if (playerAnimator == null)
        {
            playerAnimator = player.GetComponentInChildren<Animator>();
        }

        if (playerAnimator)
        {
            playerAnimator.SetTrigger("isJumping");
        }
        
        if(leftPos == false)
        {
            transform.DOMove(leftPosition.gameObject.transform.position, 1f);
        }
        if(leftPos == true)
        {
            transform.DOMove(mainPosition.gameObject.transform.position, 1f);
            leftPos = false;
        }
       
        //SoundManager.Instance.PlaySound(SoundManager.SoundTypes.Jump);

    }
    
       
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Letter"))
        {
            SoundManager.Instance.PlayBossSound(SoundManager.BossSoundTypes.Negative);
            sceneManagement.GameRestart();
        }
        
        if (collision.transform.CompareTag("SpecialLetters"))
        {
            if (countdown.currentTime - specialLetterTimeDecrease <= 0)
            {
                countdown.currentTime = 0;
            }
            else
            {
                countdown.currentTime -= specialLetterTimeDecrease;
            }
        }
    }

    public void StopMovement()
    {
        isGameStarted = false;
        playerCollider.enabled = false;
    }
}
