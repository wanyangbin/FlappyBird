using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayereDie : MonoBehaviour
{
    public GameObject gameOver;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            AudoiManager._instance.SetAudio(AudioClipType.hit);
            if (!gameOver.activeSelf)
            {
                gameOver.SetActive(true);
                //AudoiManager._instance.SetAudio(AudioClipType.die);
            }
            MapMove map1 = GameObject.Find("Map1").GetComponent<MapMove>();
            map1.enabled = false;
            MapMove map2 = GameObject.Find("Map2").GetComponent<MapMove>();
            map2.enabled = false;

            Rigidbody2D playerRigidbody2D = GameObject.Find("Player").GetComponent<Rigidbody2D>();
            Destroy(playerRigidbody2D);
        }
    }
}
