using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject returnButton;
    public GameObject fuelUI;

    [SerializeField] private GameObject gameOverCanvas;


    private void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
        }

        Time.timeScale = 1f;
    }

    //Sets game over screen active and pauses game play
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
       

        Time.timeScale = 0f;
    }

    //Restarts the game - returns to rocket menu
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    //Triggers game over canvas after a set interval, hides part of HUD and pauses game play
    public IEnumerator DelayedGameOver(int delay)
    {
       
        
        yield return new WaitForSeconds(delay);
        gameOverCanvas.SetActive(true);
        returnButton.SetActive(false);
        fuelUI.SetActive(false);
        Time.timeScale = 0f;

    }
}
