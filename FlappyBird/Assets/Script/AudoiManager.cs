using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum AudioClipType
{
    die,
    hit,
    point,
    wing
}
public class AudoiManager : MonoBehaviour
{
    public static AudoiManager _instance;

    public AudioClip[] allAudioClips;
    public AudioSource audioSourceBG;
    public AudioSource audioSourceOther;
    public AudioSource playerAudiosource;
    
    void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        audioSourceBG.mute = GameSever.getSingleton().isMute;
        audioSourceOther.mute = GameSever.getSingleton().isMute;
        playerAudiosource.mute = GameSever.getSingleton().isMute;
    }

    public void SetAudio(AudioClipType index)
    {
        if (GameSever.getSingleton().isMute)
        {
            return;
        }
        audioSourceOther.clip = allAudioClips[(int)index];
        audioSourceOther.Play();
    }
}
