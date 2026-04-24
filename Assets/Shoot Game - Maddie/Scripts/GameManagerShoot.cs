using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerShoot : MonoBehaviour
{
    public static GameManagerShoot instance;
    public GameObject returnButton;
    public GameObject laser;
    public GameObject laser2;

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
        returnButton.SetActive(false);
        laser.SetActive(false);
        laser2.SetActive(false);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
