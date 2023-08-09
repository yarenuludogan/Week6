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
            case 0: drp1.text = "Yaþ:18"; break;
            case 1: drp1.text = "Yaþ:19"; break;
            case 2: drp1.text = "Yaþ:20"; break;
            case 3: drp1.text = "Yaþ:21"; break;
            case 4: drp1.text = "Yaþ:22"; break;
            case 5: drp1.text = "Yaþ:3"; break;
            case 6: drp1.text = "Yaþ:24"; break;
        }
    }
    public void sýnýf(int ind)
    {
        switch (ind)
        {
            case 0: drp2.text = "Sýnýf: Hazýrlýk"; break;
            case 1: drp2.text = "Sýnýf: 1. Sýnýf"; break;
            case 2: drp2.text = "Sýnýf: 2. Sýnýf"; break;
            case 3: drp2.text = "Sýnýf: 3. Sýnýf"; break;
            case 4: drp2.text = "Sýnýf: 4. Sýnýf"; break;
            case 5: drp2.text = "Sýnýf: 5. Sýnýf"; break;
            case 6: drp2.text = "Sýnýf: 6. Sýnýf"; break;
            case 7: drp2.text = "Sýnýf: Yüksek Lisans"; break;
        }
    }
}



   
