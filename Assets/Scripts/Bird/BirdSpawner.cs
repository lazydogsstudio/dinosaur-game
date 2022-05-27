using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{

    public GameObject bird;
    void Start()
    {
        StartCoroutine(BirdSpawn());
    }

    IEnumerator BirdSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(10f, 15f));
            Instantiate(bird, transform.position, Quaternion.identity);
        }
    }
}
