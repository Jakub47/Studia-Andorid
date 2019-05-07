using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIElements : MonoBehaviour
{
    public GameObject Content;
    public GameObject ButtonPrefab;
    public Text textInFragment;
    public List<Sprite> Images;
    public Image img;

    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    //public void ActivatePanel(string PanelName)
    //{
    //    GameObject panelToActivate;
    //    foreach (GameObject panel in PanelsWithFragment)
    //    {
    //        if (panel.name.ToLower() == PanelName.ToLower())
    //            panelToActivate = panel;
    //    }
    //    PanelsWithFragment.ForEach(a =>
    //    {
    //        if (a.name.ToLower() == PanelName.ToLower())
    //            a.SetActive(true);
    //        else
    //            a.SetActive(false);
    //    });
    //}

    public void ShowPizza()
    {
        DeleteAllIfExists();

        GameObject button1 = Instantiate(ButtonPrefab);
        button1.transform.parent = Content.transform;
        button1.GetComponentInChildren<Text>().text = "Margarita";
        Button btn1 = button1.GetComponent<Button>();
        btn1.onClick.AddListener(() => ChangeInfoInFragment(button1.GetComponentInChildren<Text>().text));

        GameObject button2 = Instantiate(ButtonPrefab);
        button2.transform.parent = Content.transform;
        button2.GetComponentInChildren<Text>().text = "Peperoni";
        Button btn2 = button2.GetComponent<Button>();
        btn2.onClick.AddListener(() => ChangeInfoInFragment(button2.GetComponentInChildren<Text>().text));

        GameObject button3 = Instantiate(ButtonPrefab);
        button3.transform.parent = Content.transform;
        button3.GetComponentInChildren<Text>().text = "Meat";
        Button btn3 = button3.GetComponent<Button>();
        btn3.onClick.AddListener(() => ChangeInfoInFragment(button3.GetComponentInChildren<Text>().text));
    }

    public void ChangeInfoInFragment(string text)
    {
        for (int i = 0; i < 9; i++)
        {
            if (Images[i].name == text)
            {
                img.sprite = Images[i];
            }
        }

        if (text == "Margarita")
            textInFragment.text = "Pizza margherita ma tylko trzy główne składniki: ciasto, sos pomidorowy i ser. Jeżeli masz pod ręką świeżą bazylię to bardzo dobrze, ale z";
        else if (text == "Peperoni")
            textInFragment.text = "Pizza pepperoni to jedna z najpopularniejszych pozycji w menu każdej pizzerii. Jej podstawowa wersja jest bardzo prosta i zawiera oprócz";
        else if (text == "Meat")
            textInFragment.text = "Pizza mięsna. 1. Ciasto: Wodę podgrzewamy w garnuszku, dodajemy do niej drożdży, cukier i 1 łyżkę maki. Wszystko wymieszać i odstawić do wyrośnięcia na ";
        else if (text == "Pepsi")
            textInFragment.text = "gazowany napój typu cola produkowany przez koncern PepsiCo, sprzedawany w wielu krajach. Głównym rywalem Pepsi na rynku jest Coca-Cola";
        else if (text == "Cola")
            textInFragment.text = "marka napoju gazowanego przedsiębiorstwa The Coca-Cola Company. Powstała pod koniec XIX wieku i jest obecnie jedną z najpopularniejszych marek na świecie. Od 1960 roku charakterystyczny kształt butelki jest także prawnie zastrzeżony. ";
        else if (text == "Fanta")
            textInFragment.text = "napój gazowany o smaku owocowym produkowany przez The Coca-Cola Company";
        else if (text == "Ketchup")
            textInFragment.text = "sos pomidorowy podawany na zimno, o gamie smaków od łagodnego do ostrego, barwy zwykle ciemnoczerwonej, czerwonobrązowej, rzadziej zielonej, stosowany do potraw mięsnych, kanapek, pizzy, frytek itp.";
        else if (text == "Musztarda")
            textInFragment.text = "zimny sos, którego głównym składnikiem są ziarna gorczycy – białej, czarnej lub sarepskiej; w wielu językach jako 'musztarda' funkcjonuje słowo 'gorczyca'.";
        else if (text == "Czosnkowy")
            textInFragment.text = "Sos czosnkowy – aromatyczny biały sos, sporządzany głównie na bazie jogurtu naturalnego lub (rzadziej) śmietany.";
    }

    public void ShowDrinks()
    {
        DeleteAllIfExists();
        GameObject button1 = Instantiate(ButtonPrefab);
        button1.transform.parent = Content.transform;
        button1.GetComponentInChildren<Text>().text = "Pepsi";
        Button btn1 = button1.GetComponent<Button>();
        btn1.onClick.AddListener(() => ChangeInfoInFragment(button1.GetComponentInChildren<Text>().text));

        GameObject button2 = Instantiate(ButtonPrefab);
        button2.transform.parent = Content.transform;
        button2.GetComponentInChildren<Text>().text = "Cola";
        Button btn2 = button2.GetComponent<Button>();
        btn2.onClick.AddListener(() => ChangeInfoInFragment(button2.GetComponentInChildren<Text>().text));

        GameObject button3 = Instantiate(ButtonPrefab);
        button3.transform.parent = Content.transform;
        button3.GetComponentInChildren<Text>().text = "Fanta";
        Button btn3 = button3.GetComponent<Button>();
        btn3.onClick.AddListener(() => ChangeInfoInFragment(button3.GetComponentInChildren<Text>().text));
    }

    public void ShowSoss()
    {
        DeleteAllIfExists();

        GameObject button1 = Instantiate(ButtonPrefab);
        button1.transform.parent = Content.transform;
        button1.GetComponentInChildren<Text>().text = "Ketchup";
        Button btn1 = button1.GetComponent<Button>();
        btn1.onClick.AddListener(() => ChangeInfoInFragment(button1.GetComponentInChildren<Text>().text));

        GameObject button2 = Instantiate(ButtonPrefab);
        button2.transform.parent = Content.transform;
        button2.GetComponentInChildren<Text>().text = "Musztarda";
        Button btn2 = button2.GetComponent<Button>();
        btn2.onClick.AddListener(() => ChangeInfoInFragment(button2.GetComponentInChildren<Text>().text));

        GameObject button3 = Instantiate(ButtonPrefab);
        button3.transform.parent = Content.transform;
        button3.GetComponentInChildren<Text>().text = "Czosnkowy";
        Button btn3 = button3.GetComponent<Button>();
        btn3.onClick.AddListener(() => ChangeInfoInFragment(button3.GetComponentInChildren<Text>().text));
    }

    public void DeleteAllIfExists()
    {
        int i = 0;

        //Array to hold all child obj
        GameObject[] allChildren = new GameObject[Content.transform.childCount];

        //Find all child obj and store to that array
        foreach (Transform child in Content.transform)
        {
            allChildren[i] = child.gameObject;
            i += 1;
        }

        //Now destroy them
        foreach (GameObject child in allChildren)
        {
            DestroyImmediate(child.gameObject);
        }
    }
}
