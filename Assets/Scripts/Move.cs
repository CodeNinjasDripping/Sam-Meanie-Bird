using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Default speed")]
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
