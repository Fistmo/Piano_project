using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    AudioSource audio;
    AudioClip Music;
    string songName;
    bool played;
    void Start()
    {
        GManager.instance.Start = false;
        songName = "古老的大鐘";
        audio = GetComponent<AudioSource>();
        Music = (AudioClip)Resources.Load("Musics/" + songName);
        played = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touches.Length > 0) && (Input.touches[0].phase == TouchPhase.Ended) && (Input.touches[0].phase != TouchPhase.Canceled) && !played)
        {
            GManager.instance.Start = true;
            GManager.instance.StartTime = Time.time;
            played = true;
            audio.PlayOneShot(Music);
        }
    }
}