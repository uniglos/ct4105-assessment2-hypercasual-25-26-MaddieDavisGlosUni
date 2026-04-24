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

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
       

        Time.timeScale = 0f;
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public IEnumerator DelayedGameOver(int delay)
    {
        //Debug.Log("game over");
        
        yield return new WaitForSeconds(delay);
        gameOverCanvas.SetActive(true);
        returnButton.SetActive(false);
        fuelUI.SetActive(false);
        Time.timeScale = 0f;

    }
}
