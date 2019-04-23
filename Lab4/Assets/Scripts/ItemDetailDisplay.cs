using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDetailDisplay : MonoBehaviour {

    public GameObject ItemPanel;
    public GameObject PizzaPanel;
    public GameObject NapojePanel;
    public GameObject SosyPanel;

    public Image img;
    public Text Title;
    public Text Description;

    public Dictionary<string, string> titleDescription;

    public List<Sprite> ItemImages;

    // Use this for initialization
    void Start ()
    {
        titleDescription = new Dictionary<string, string>();
        titleDescription.Add("margarita", "Margaria dobre");
        titleDescription.Add("meat", "Mięsne dobre");
        titleDescription.Add("peperoni", "Peperoni dobre");
        titleDescription.Add("cocacola", "Dobrze musuje");
        titleDescription.Add("pepsi", "Niebieska najlepsza");
        titleDescription.Add("fanta", "Zółta is the best");
        titleDescription.Add("czosnkowy", "Najlepszy na wampiry");
        titleDescription.Add("ketchup", "ketchup najelpszy do wszystkiego");
        titleDescription.Add("musztarda", "dla hardkorow");

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ShowItemPanel(string name)
    {
        if(name == "margarita" || name == "meat" || name== "peperoni")
        {
            PizzaPanel.SetActive(false);
            CurrentPanel.CurrentPanelInList = PizzaPanel;
            ItemPanel.SetActive(true);
        }

        else if (name == "cocacola" || name == "pepsi" || name == "fanta")
        {
            NapojePanel.SetActive(false);
            CurrentPanel.CurrentPanelInList = NapojePanel;
            ItemPanel.SetActive(true);
        }
        else
        {
            SosyPanel.SetActive(false);
            CurrentPanel.CurrentPanelInList = SosyPanel;
            ItemPanel.SetActive(true);
        }

        changeImage(name);
        Title.text = name;
        Description.text = titleDescription[name];
    }

    public void changeImage(string name)
    {
        for (int i = 0; i < 9; i++)
        {
            if (ItemImages[i].name.ToLower() == name.ToLower())
            {
                img.sprite = ItemImages[i];
            }
        }
    }

    public void returnToPanel()
    {
        ItemPanel.SetActive(false);
        CurrentPanel.CurrentPanelInList.SetActive(true);
    }
}
