using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIStart : MonoBehaviour
{
    public GameObject Panel_Start;
    public GameObject Panel_Rate;
    public GameObject Panel_Rank;
    public Toggle _auido;
    public AudioSource audiosourcebg;
    public Text score;
    public Text maxscore;
   

    void Awake()
    {
        _auido.isOn = GameSever.getSingleton().isMute;
    }

    void Update()
    {
        GameSever.getSingleton().isMute = _auido.isOn;
        audiosourcebg.mute = GameSever.getSingleton().isMute;
    }

    public void ClickOpenPanel_Rate()
    {
        if (!Panel_Rate.activeSelf)
        {
            Panel_Rate.SetActive(true);
        }
        if (Panel_Start.activeSelf)
        {
            Panel_Start.SetActive(false);
        }
    }
    public void ClickOpenPanel_Rank()
    {
        score.text = GameSever.getSingleton().score.ToString();
        maxscore.text = GameSever.getSingleton().maxscore.ToString();
        if (!Panel_Rank.activeSelf)
        {
            Panel_Rank.SetActive(true);
        }
        if (Panel_Start.activeSelf)
        {
            Panel_Start.SetActive(false);
        }
    }
    public void ClickClosePanel_Rank()
    {
        if (Panel_Rank.activeSelf)
        {
            Panel_Rank.SetActive(false);
        }
        if (!Panel_Start.activeSelf)
        {
            Panel_Start.SetActive(true);
        }
    }
    public void ClickStartGame()
    {
        GameSever.getSingleton().Reset();
        SceneManager.LoadScene("Main");
    }
    public void Clickexit()
    {
        Application.Quit();
    }
}
