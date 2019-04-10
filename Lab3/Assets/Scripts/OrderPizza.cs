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
        switch(pizza)
        {
            case "margarita":
                totalCost += 20; pizzaPrice = 20;
                break;
            case "peperoni":
                totalCost += 25; pizzaPrice = 25;
                break;
            case "meat":
                totalCost += 29; pizzaPrice = 29;
                break;
        }

        if(sos.value != 0)
        {
            totalCost += 10; sosPrice = 10;
        }

        if(pepsi.isOn)
        {
            totalCost += 5; pepsiPrice = 5;
        }

        if(frytki.isOn)
        {
            totalCost += 12; frytkiPrice = 12;
        }

        panel1.SetActive(false);
        panel2.SetActive(true);
        panel2.SendMessage("SetValuesInTable",new Paragon { PizzaPrice = pizzaPrice , FrytkiPrice = frytkiPrice, PepsiPrice = pepsiPrice,
                            SosPrice = sosPrice, Result = totalCost});
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
