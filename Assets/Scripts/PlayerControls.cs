using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Game Controller Object for controling the game")]
    public GameController gameController;
    [Header("Velocity")]
    public float velocity = 1;
    private Rigidbody rb;
    private float objectHeight;
    void Start()
    {
        GameController gc = GetComponent<GameController>();
        Time.timeScale = 1;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        float objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * velocity;
        }    
    }
}
