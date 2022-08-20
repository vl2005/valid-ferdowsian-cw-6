using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControler : MonoBehaviour
{
    public Transform Spawn;
    public Transform Spawnr;
    public Transform Spawnl;

    public GameObject enemy;

    public float delay;

    void Start()
    {
        InvokeRepeating("spawnenemy", 0f, delay);
    }

    void Update()
    {

    }

    void spawnenemy()
    {
        int randNum = Random.Range(1, 4);
        if (randNum == 1)
        {
            Instantiate(enemy, Spawnl);
        }
        else if (randNum == 2)
        {
            Instantiate(enemy, Spawn);
        }
        else
        {
            Instantiate(enemy, Spawnr);
        }
    }
}

