using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{
    public Toggle erkek, kadýn, belirtmemis;
    public TMP_Text text1;
    public void erkek1()
    {
        text1.text = "Cinsiyet:" + erkek.tag;

    }
    public void kadýn1()
    {
        text1.text = "Cinsiyet:" + kadýn.tag;

    }
    public void belirtmemis1()
    {
        text1.text = "Cinsiyet:" + belirtmemis.tag;

    }

}
