using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{
    public Toggle erkek, kad�n, belirtmemis;
    public TMP_Text text1;
    public void erkek1()
    {
        text1.text = "Cinsiyet:" + erkek.tag;

    }
    public void kad�n1()
    {
        text1.text = "Cinsiyet:" + kad�n.tag;

    }
    public void belirtmemis1()
    {
        text1.text = "Cinsiyet:" + belirtmemis.tag;

    }

}
