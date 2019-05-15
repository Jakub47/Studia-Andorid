using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsertToDB : MonoBehaviour
{
    public GameObject Thispanel;
    public GameObject panel1;
    public GameObject panel2;

    public Dropdown Type;
    public Text label;
    public InputField nazwa;
    public InputField cena;
    public InputField common;

    string URL = "http://localhost/lab/insertPizza.php";
    string URL1 = "http://localhost/lab/insertNapoj.php";
    string URL2 = "http://localhost/lab/insertSos.php";

    // Use this for initialization
    void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void insert()
    {
        var op = Type.captionText.text;
        if(op == "Pizza")
        {
            WWWForm form = new WWWForm();
            form.AddField("nazwa", nazwa.text);
            form.AddField("cena", cena.text);
            form.AddField("wymiary", common.text);

            WWW www = new WWW(URL, form);
        }
        else if(op == "Napoj")
        {
            WWWForm form = new WWWForm();
            form.AddField("nazwa", nazwa.text);
            form.AddField("cena", cena.text);
            form.AddField("kolor", common.text);

            WWW www = new WWW(URL1, form);
        }
        else
        {
            WWWForm form = new WWWForm();
            form.AddField("nazwa", nazwa.text);
            form.AddField("cena", cena.text);
            form.AddField("smak", common.text);

            WWW www = new WWW(URL2, form);
        }
        Thispanel.SetActive(false);
        panel1.SetActive(true);
        panel2.SetActive(true);
    }

    public void Powroc()
    {
        Thispanel.SetActive(false);
        panel1.SetActive(true);
        panel2.SetActive(true);
    }

    public void changed()
    {
        var op = Type.captionText.text;
        if (op == "Pizza")
        {
            label.text = "wymiary";
        }
        else if (op == "Napoj")
        {
            label.text = "kolor";
        }
        else
        {
            label.text = "smak";
        }
    }
}
