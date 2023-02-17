using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaAudio : MonoBehaviour
{
    private AudioSource audioToPlay;
    private bool isPlaying = false;
    public static List<MediaAudio> allMediaAudio = new List<MediaAudio>();

    // Start is called before the first frame update
    void Start() // Find the audio source and put it into this variable to play
    {
        audioToPlay = GetComponent<AudioSource>();
        allMediaAudio.Add(this);
    }

    private void OnDestroy()
    {
        allMediaAudio.Remove(this);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && isPlaying)
        {
            audioToPlay.Stop();
            isPlaying = false;
        }
    }

    public void PlayAudio()
    {
        isPlaying = !isPlaying;
        if (isPlaying)
        {
            foreach (MediaAudio mediaAudio in allMediaAudio)
            {
                if (mediaAudio != this && mediaAudio.isPlaying)
                {
                    mediaAudio.audioToPlay.Stop();
                    mediaAudio.isPlaying = false;
                }
            }
            audioToPlay.Play();
        }
        else
        {
            audioToPlay.Stop();
        }
    }

    public void GetMouseButton()
    {
        PlayAudio();
    }
}