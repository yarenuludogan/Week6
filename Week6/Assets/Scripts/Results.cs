using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using TMPro;
using UnityEngine;

using UnityEngine.UI;

public class Results : MonoBehaviour 
{
    public GameObject username, surname;
    public TMP_Text name, lastname;
    public SliderJoint2D slide, slide2,tx1,tx2;
    string text1, text2,text ;
    // Start is called before the first frame update
   public void GetName()
    {
        string name = username.GetComponent<TMP_InputField>().text;
        name = "Ýsim:  " + name;
        string lastname = surname.GetComponent<TMP_InputField>().text;
        lastname = "Soyisim: " + lastname;
    }
    // Update is called once per frame
    void Update()
    {
       
        
        
      

    }
}
