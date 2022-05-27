using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public float minSpawnTime = 3f, maxSpawnTime = 6f;

    public List<GameObject> trees;

    void Start()
    {
        StartCoroutine(TreeSpawn());
    }

    IEnumerator TreeSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            Instantiate(trees[Random.Range(0, trees.Count)], transform.position, Quaternion.identity);
        }

    }
}
