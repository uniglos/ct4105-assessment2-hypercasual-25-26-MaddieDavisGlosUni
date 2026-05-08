using UnityEngine;

public class PlayAudio : MonoBehaviour
{

    public AudioSource uiAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudioClip()
    {
        uiAudio.Play();
    }
}
