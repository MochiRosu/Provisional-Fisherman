using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyfishSpawner : MonoBehaviour
{
    public GameObject jellyfish;
    public float spawnTimer;
    public float spawnMax = 0;
    public float spawnMin = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = Random.Range(spawnMin, spawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Instantiate(jellyfish, transform.position, Quaternion.identity);
            spawnTimer = Random.Range(spawnMin, spawnMax);
        }
    }
}
