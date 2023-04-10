using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartStopPOI : MonoBehaviour
{
    private AudioSource audioSource;
    public Button button;
    public Sprite startSprite;
    public Sprite stopSprite;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ChangeStartStop()
    {
        if(audioSource.isPlaying == false)
        {
            audioSource.Play();
            button.image.sprite = stopSprite;
        }
        else
        {
            audioSource.Pause();
            button.image.sprite = startSprite;
        }
    }
}
