using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    [SerializeField] private TMP_Text drp1, drp2;

    // Start is called before the first frame update
    public void yas(int ind)
    {
        switch (ind)
        {
            case 0: drp1.text = "Ya�:18"; break;
            case 1: drp1.text = "Ya�:19"; break;
            case 2: drp1.text = "Ya�:20"; break;
            case 3: drp1.text = "Ya�:21"; break;
            case 4: drp1.text = "Ya�:22"; break;
            case 5: drp1.text = "Ya�:3"; break;
            case 6: drp1.text = "Ya�:24"; break;
        }
    }
    public void s�n�f(int ind)
    {
        switch (ind)
        {
            case 0: drp2.text = "S�n�f: Haz�rl�k"; break;
            case 1: drp2.text = "S�n�f: 1. S�n�f"; break;
            case 2: drp2.text = "S�n�f: 2. S�n�f"; break;
            case 3: drp2.text = "S�n�f: 3. S�n�f"; break;
            case 4: drp2.text = "S�n�f: 4. S�n�f"; break;
            case 5: drp2.text = "S�n�f: 5. S�n�f"; break;
            case 6: drp2.text = "S�n�f: 6. S�n�f"; break;
            case 7: drp2.text = "S�n�f: Y�ksek Lisans"; break;
        }
    }
}



   
