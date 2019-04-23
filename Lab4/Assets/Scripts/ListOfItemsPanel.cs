using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfItemsPanel : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject PizzaPanel;
    public GameObject NapojePanel;
    public GameObject SosyPanel;
    public GameObject InfoPanel;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ShowPizzaPanel()
    {
        MainPanel.SetActive(false);
        PizzaPanel.SetActive(true);
    }

    public void ShowNapojePanel()
    {
        MainPanel.SetActive(false);
        NapojePanel.SetActive(true);
    }

    public void ShowSosyPanel()
    {
        MainPanel.SetActive(false);
        SosyPanel.SetActive(true);
    }

    public void ShowInfoPanel()
    {
        MainPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }

    public void ReturnToMain()
    {
        MainPanel.SetActive(true);
        PizzaPanel.SetActive(false);
        InfoPanel.SetActive(false);
        SosyPanel.SetActive(false);
        NapojePanel.SetActive(false);
        
    }
}
