using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sender : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void change()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
}
