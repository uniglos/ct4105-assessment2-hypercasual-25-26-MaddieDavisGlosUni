using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Defines what the score is
    void Start()
    {
        scoreText.text = "Score: " + score;
    }
    //Will increase the score and update the UI when called
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}
