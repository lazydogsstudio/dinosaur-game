using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DinoMovement : MonoBehaviour
{

    PlayerInput playerInput;
    Rigidbody2D rb;
    Animator anim;
    AudioSource audioSource;
    GameManager gameManager;

    public AudioClip jumpAudio;
    bool isGrounded;


    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();


    }
    void Update()
    {
        if (playerInput.actions["Jump"].triggered && !gameManager.isGameOver)
        {

            if (isGrounded)
            {
                rb.velocity = Vector2.up * 8f;
                anim.SetBool("isJump", true);
                audioSource.PlayOneShot(jumpAudio);
                isGrounded = false;

            }
        }

        if (gameManager.isGameOver)
        {
            anim.SetBool("isDie", true);
        }



    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            print("isGrounded");
            anim.SetBool("isJump", false);
            isGrounded = true;

        }
    }


}
