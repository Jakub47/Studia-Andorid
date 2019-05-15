using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class pizzaSelect : MonoBehaviour
{
    string URL = "http://localhost/lab/pizzaSelect.php";
    string URL1 = "http://localhost/lab/napojeSelect.php";
    string URL2 = "http://localhost/lab/sosySelect.php";


    public Text textArea;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject inserPanel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Wywolaj(string pozycja)
    {
        if (pozycja == "pizze")
        {
            StopAllCoroutines();
            StartCoroutine(PizzaFromDB());
        }
        else if (pozycja == "napoje")
        {
            StopAllCoroutines();
            StartCoroutine(NapojeFromDB());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(SosyFromDB());
        }        
    }

    public void ZmienPanel()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        inserPanel.SetActive(true);
    }

    public IEnumerator PizzaFromDB()
    {
        string[] pizzas;
        textArea.text = "";
        WWW allPizza = new WWW(URL);
        yield return allPizza;
        string allPizzaString = allPizza.text;
        pizzas = allPizzaString.Split('N');
        pizzas = pizzas.Where(a => a != string.Empty).ToArray();

        for (int i = 0; i < pizzas.Length; i++)
        {
            if (i == pizzas.Length - 1)
            {
                pizzas[i] = "N" + pizzas[i];
                textArea.text += pizzas[i];
            }
            else
            {
                pizzas[i] = "N" + pizzas[i];
                textArea.text += pizzas[i] + Environment.NewLine;
            }
        }
    }

    public IEnumerator NapojeFromDB()
    {
        textArea.text = "";
        string[] napoje;
        WWW allPizza = new WWW(URL1);
        yield return allPizza;
        string allNapojeString = allPizza.text;
        napoje = allNapojeString.Split('N');
        napoje = napoje.Where(a => a != string.Empty).ToArray();

        for (int i = 0; i < napoje.Length; i++)
        {
            if (i == napoje.Length - 1)
            {
                napoje[i] = "N" + napoje[i];
                textArea.text += napoje[i];
            }
            else
            {
                napoje[i] = "N" + napoje[i];
                textArea.text += napoje[i] + Environment.NewLine;
            }
        }
    }

    public IEnumerator SosyFromDB()
    {
        textArea.text = "";
        string[] sosy;
        WWW allSosy = new WWW(URL2);
        yield return allSosy;
        string allPizzaString = allSosy.text;
        sosy = allPizzaString.Split('N');
        sosy = sosy.Where(a => a != string.Empty).ToArray();

        for (int i = 0; i < sosy.Length; i++)
        {
            if(i == sosy.Length - 1)
            {
                sosy[i] = "N" + sosy[i];
                textArea.text += sosy[i];
            }
            else
            {
                sosy[i] = "N" + sosy[i];
                textArea.text += sosy[i] + Environment.NewLine;
            }            
        }
    }


}
