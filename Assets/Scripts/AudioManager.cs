using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundAudioSource;
    [SerializeField] private AudioClip backgroundClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playBackgroundMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playBackgroundMusic() { 
        backgroundAudioSource.clip = backgroundClip;
        backgroundAudioSource.Play();
    }
}
