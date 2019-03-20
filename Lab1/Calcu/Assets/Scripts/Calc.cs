using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calc : MonoBehaviour
{
    public Dropdown firstNumber;
    public Dropdown operatorToCalc;
    public Dropdown secondtNumber;
    public Text text;
    // Use this for initialization
    void Start ()
    {
        var listTemp = new Dropdown.OptionDataList();
		for(int i = 1;i<=100;i++)
        {
            firstNumber.options.Add(new Dropdown.OptionData(i.ToString()));
            secondtNumber.options.Add(new Dropdown.OptionData(i.ToString()));
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Count()
    {
        float f = float.Parse(firstNumber.captionText.text);
        var op = operatorToCalc.captionText.text;
        float sc = float.Parse(secondtNumber.captionText.text);
        if (op == "+")
            text.text = "Value is " + (f + sc);
        if (op == "-")
            text.text = "Value is " + (f - sc);
        if (op == "*")
            text.text = "Value is " + (f * sc);
        if (op == "/")
            text.text = "Value is " + (f / sc);

    }
}
