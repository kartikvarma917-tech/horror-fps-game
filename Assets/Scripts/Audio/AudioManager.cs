using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource effectsSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void PlayMusic(AudioClip musicClip)
    {
        musicSource.clip = musicClip;
        musicSource.Play();
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }

    public void PlaySoundEffect(AudioClip soundEffect)
    {
        effectsSource.PlayOneShot(soundEffect);
    }
}