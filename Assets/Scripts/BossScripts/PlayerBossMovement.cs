using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class PlayerBossMovement : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> mainPosition;
    public List<GameObject> leftPosition;
    public List<GameObject> rightPosition;
    
    private int currentStep = 0;

    public bool leftPos = false;
    public bool rightPos = false;
    
    public GameObject player;
    public Animator playerAnimator;
    public Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = player.GetComponentInChildren<Rigidbody>();
        playerAnimator = player.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ButtonChecking();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Crashed"))
        {
            //SoundManager.Instance.PlaySound(SoundManager.SoundTypes.Crash);
            collision.transform.GetComponent<MeshRenderer>().enabled = false;
            collision.transform.GetComponent<BoxCollider>().enabled = false;
            
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
            //playerAnimator.SetBool("isRightJumping", true);
        }

        if(rightPos == false)
        {
            transform.DOMove(rightPosition[0].gameObject.transform.position, 1f);
        }
        if(rightPos == true)
        {
            transform.DOMove(mainPosition[0].gameObject.transform.position, 1f);
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
            //playerAnimator.SetBool("isLeftJumping", true);
        }
        
        if(leftPos == false)
        {
            transform.DOMove(leftPosition[0].gameObject.transform.position, 1f);
        }
        if(leftPos == true)
        {
            transform.DOMove(mainPosition[0].gameObject.transform.position, 1f);
            leftPos = false;
        }
       
        //SoundManager.Instance.PlaySound(SoundManager.SoundTypes.Jump);

    }
}
