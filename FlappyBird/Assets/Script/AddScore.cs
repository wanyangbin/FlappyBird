using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            GameSever.getSingleton().score++;
            GameSever.getSingleton().SetMaxScore();
            AudoiManager._instance.SetAudio(AudioClipType.point);
        }
    }
}
