using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawn : MonoBehaviour
{
    public GameObject Fish;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float TimeBetweenSpawn;
    public float shortenTime;
    public float min_TBS;
    private float SpawnTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time>5)
        {
            if (Time.time > SpawnTime)
            {
                Spawn();
                SpawnTime = Time.time + TimeBetweenSpawn;
            }
        }    
    }
    void FixedUpdate()
    {
        if (TimeBetweenSpawn > min_TBS)
        {
            TimeBetweenSpawn -= shortenTime;
        }
        else
        {
            TimeBetweenSpawn = min_TBS;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(Fish, transform.position + new Vector3(randomY, randomY, 0), transform.rotation);
    }
}
