using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;

    [SerializeField] private TextMeshProUGUI currentScoreText;

    private int score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        currentScoreText.text = score.ToString();


    }

    public void UpdateScore()
    {
        score++;
        currentScoreText.text = score.ToString();
    }
}
