using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public float speed = 3f;
    AudioSource audioSource;
    public AudioClip gameOverSound;
    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        audioSource = GetComponent<AudioSource>();

    }
    void Update()
    {
        if (!gameManager.isGameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

            if (transform.position.x < -44f)
            {
                Destroy(gameObject);
            }
        }



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.isGameOver = true;
            audioSource.PlayOneShot(gameOverSound);

        }
    }
}
