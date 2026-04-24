using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextAppear : MonoBehaviour
{
    public TextMeshProUGUI introText;
    [SerializeField] float timeToAppear = 2f;
    [SerializeField] float timewhenDisappear;

    public void EnableText()
    {
        introText.enabled = true;
        timewhenDisappear = Time.time + timeToAppear;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnableText();
    }

    // Update is called once per frame
    void Update()
    {
        if (introText.enabled && (Time.time >= timewhenDisappear))
        {
            introText.enabled = false;
        }
    }
}
