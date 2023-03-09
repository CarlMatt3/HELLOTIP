using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXSound : MonoBehaviour
{
    public AudioSource sfxPlayer;

    public void playSFX()
    {
        sfxPlayer.Play();
    }
}
