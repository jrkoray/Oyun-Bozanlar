using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{

    public AudioSource sourceMenuMusic;
    public AudioSource sourceUiButtonSFX;

    public void Awake()
    {
        MainMenu();
    }

    public void MainMenu()
    {
        sourceMenuMusic.loop = true;
        sourceMenuMusic.Play();
    }

    public void MainMenuStop()
    {
        sourceMenuMusic.loop = false;
        sourceMenuMusic.Stop();
    }

    public void UiButtonSFX()
    {
        sourceUiButtonSFX.loop = false;
        sourceUiButtonSFX.PlayOneShot(sourceUiButtonSFX.clip,1);
    }

    
}
