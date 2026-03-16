using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerShoot : MonoBehaviour
{
    public static GameManagerShoot instance;

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
}
