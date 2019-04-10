using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowResult : MonoBehaviour
{
    public Text PizzaPrice;
    public Text SosPrice;
    public Text FrytkiPrice;
    public Text PepsiPrice;
    public Text Result;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void SetValuesInTable(Paragon paragon)
    {
        PizzaPrice.text = paragon.PizzaPrice.ToString();
        SosPrice.text = paragon.SosPrice.ToString();
        FrytkiPrice.text = paragon.FrytkiPrice.ToString();
        PepsiPrice.text = paragon.PepsiPrice.ToString();
        Result.text = paragon.Result.ToString();
    }
}
