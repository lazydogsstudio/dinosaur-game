using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public float speed;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

    }
    void Update()
    {

        if (!gameManager.isGameOver)
        {

            if (transform.position.x < -22f)
            {
                transform.position = new Vector3(0f, transform.position.y, transform.position.z);
            }
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
