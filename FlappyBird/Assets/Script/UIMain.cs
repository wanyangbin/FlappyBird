using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMain : MonoBehaviour
{
    public Text score;

    void Update()
    {
        score.text = GameSever.getSingleton().score.ToString();
    }
    public void ClickRestart()
    {
        GameSever.getSingleton().Reset();
        SceneManager.LoadScene("Main");
    }
    public void ClickBack()
    {
        SceneManager.LoadScene("Start");
    }
    public void Clickexit()
    {
        Application.Quit();
    }
}
