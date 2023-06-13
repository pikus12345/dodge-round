using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float minWaitTime;
    public float maxWaitTime;

    public float time;
    public float timer;

    public GameObject[] spawnPrefabs;
    private void Update()
    {
        if (!GameManager.isGameRunning)
            return;
        timer += Time.deltaTime;
        if (timer > time)
        {
            NextTimer();
        }
    }
    public void NextTimer()
    {
        ResetTimer();
        GenerateNewTimer();
        Spawn();
    }
    public void ResetTimer()
    {
        timer = 0;
    }
    public void GenerateNewTimer()
    {
        time = Random.Range(minWaitTime,maxWaitTime);
    }
    public void Spawn()
    {
        Instantiate(spawnPrefabs[Random.Range(0, spawnPrefabs.Length)], transform.position, Quaternion.identity);
    }
}
