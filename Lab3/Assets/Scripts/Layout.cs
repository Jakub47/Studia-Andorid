using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Layout : MonoBehaviour {

    public Dropdown pizzasDropDown;
    public Image img;
    public List<Sprite> PiizaImages;

    public List<string> pizzasNames;

    // Use this for initialization
    void Start ()
    {
        pizzasNames.Add("margarita"); pizzasNames.Add("peperoni"); pizzasNames.Add("meat");

        for (int i = 0; i < 3; i++)
        {
            pizzasDropDown.options.Add(new Dropdown.OptionData(pizzasNames[i]));
        }
        pizzasDropDown.value = 0;
        img.sprite = PiizaImages[0];
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void changeImage()
    {
        for (int i = 0; i < 3; i++)
        {
            if (PiizaImages[i].name == pizzasDropDown.captionText.text)
            {
                img.sprite = PiizaImages[i];
            }
        }
    }
}
