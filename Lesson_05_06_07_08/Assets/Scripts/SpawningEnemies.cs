using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEnemies : MonoBehaviour
{
    public GameObject Enemy;
    void Start()
    {
        StartCoroutine(Spawning());
    }

    IEnumerator Spawning()
    {
        Vector2 spawnPoint = new Vector2(Random.Range(-8,8), Random.Range(0.7f,3));

        while (true)
        {
            Instantiate(Enemy, spawnPoint, Quaternion.identity, transform);
            yield return new WaitForSeconds(3f);
        }
    }
}