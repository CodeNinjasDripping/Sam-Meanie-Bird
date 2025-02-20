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
    private Rigidbody2D rb;
    private float objectHeight;
    void Start()
    {
        GameController gc = GetComponent<GameController>();
        //Time.timeScale = 1;
         rb = GetComponent<Rigidbody2D>();
         objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * velocity;
        }

        
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HighSpike" || collision.gameObject.tag == "LowSpike" || collision.gameObject.tag == "Ground")
        {
            GameObject.Find("GameController").GetComponent<GameController>().GameOver();
        }
    }
}
