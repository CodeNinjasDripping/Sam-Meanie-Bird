﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Spikes Object for controlling the game")]
    public GameObject Spike;
    [Header("Default Height")]
    public float height;
    void Start()
    {
        InvokeRepeating("InstantiateObject",1f,4f);
        
    }

    // Update is called once per frame
    void Update()
    {
        Spike.transform.position = new Vector3(5,Random.Range(-height,height),0);
    }
    void InstantiateObject()
    {
        Instantiate(Spike, Spike.transform.position, Spike.transform.rotation);
    }
}
