using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderPizza : MonoBehaviour
{
    private int totalCost;

    public Dropdown pizzasDropDown;
    public int pizzaPrice;

    public Slider sos;
    public int sosPrice = 0;

    public Toggle pepsi;
    public int pepsiPrice = 0;

    public Toggle frytki;
    public int frytkiPrice = 0;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    void Start ()
    {
        totalCost = 0;
    }
	
    public void ShowActivityAndCount()
    {
        string pizza = pizzasDropDown.captionText.text;
        Paragon paragon = new Paragon();

        switch(pizza)
        {
            case "margarita":
                paragon.Result += 20; paragon.PizzaPrice = 20;
                break;
            case "peperoni":
                paragon.Result += 25; paragon.PizzaPrice = 25;
                break;
            case "meat":
                paragon.Result += 29; paragon.PizzaPrice = 29;
                break;
        }

        if(sos.value != 0)
        {
            paragon.Result += 10; paragon.SosPrice = 10;
        }
        

        if(pepsi.isOn)
        {
            paragon.Result += 5; paragon.PepsiPrice = 5;
        }


        if(frytki.isOn)
        {
            paragon.Result += 12; paragon.FrytkiPrice = 12;
        }


        panel1.SetActive(false);
        panel2.SetActive(true);
        panel2.SendMessage("SetValuesInTable",paragon);
    }

    public void RetrunToMainActivity()
    {
        panel2.SetActive(false);

        panel1.SetActive(true);
    }

    public void ActivateResult()
    {
        panel2.SetActive(false);
        panel3.SetActive(true);
    }

    public void RetrunToMainActivityAfterSubmit()
    {
        panel3.SetActive(false);
        panel1.SetActive(true);
    }


}
