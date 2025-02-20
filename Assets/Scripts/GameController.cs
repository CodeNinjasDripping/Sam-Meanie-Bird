using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;

    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 1;
        scoreCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        spawner.SetActive(true);
     }

    // Update is called once per frame
    public void GameOver()
    {
        print("Game Over");
        gameOverCanvas.SetActive(true);
        spawner.SetActive(false);
        Time.timeScale = 0;
    }
}
