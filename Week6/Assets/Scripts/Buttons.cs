using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public void Exit()
    {
        Application.Quit();

    }
    public void StartGame()
    {
        SceneManager.LoadScene("AnketSahnesi");
    }
    public void ReturnScene()
    {
        SceneManager.LoadScene("Sample Scene");
    }
    public void SliderValue(float value)
    {
    print(value);
    }
    public void Toggle(Boolean t�k)
    {
        if (t�k)
        {

        }
    }
    public void �sim(string isim)
    {

    }
}
