using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using Battlehub.Dispatcher;


public class pizzaSelect : MonoBehaviour
{
    public Text textArea;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject inserPanel;

    public Thread thread1;
    public Thread thread2;
    public Thread thread3;

    // Use this for initialization
    void Start()
    {
        thread1 = new Thread(PizzaFromDB);
        thread2 = new Thread(NapojeFromDB);
        thread3 = new Thread(SosyFromDB);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Wywolaj(string pozycja)
    {
        if (pozycja == "pizze")
        {
                //thread1.Abort();
                //thread1 = null;
                thread1 = new Thread(PizzaFromDB);
                //thread1.Start();
                thread1.Start();

        }
        else if (pozycja == "napoje")
        {
            //thread2.Abort();
            //thread1 = null;
            thread2 = new Thread(NapojeFromDB);
            //thread1.Start();
            thread2.Start();
        }
        else
        {
           // thread3.Abort();
            //thread1 = null;
            thread3 = new Thread(SosyFromDB);
            //thread1.Start();
            thread3.Start();
        }        
    }

    public void ZmienPanel()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        inserPanel.SetActive(true);
    }

    public void PizzaFromDB()
    {
        string s = "";
        string connectionString = @"Data Source=192.168.1.128;Initial Catalog=Pizzeria;Persist Security Info=True;User ID=user1;Password=bergmann1;";
        try
        {
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "select * from Pizza";
            SqlDataReader czytnik = komendaSQL.ExecuteReader();
            while (czytnik.Read())
            {
                s += czytnik["id"].ToString() + "   " + czytnik["nazwa"].ToString() + "   " + czytnik["cena"].ToString() + czytnik["wymiary"].ToString() + Environment.NewLine ;
                //pizzas.Append(czytnik["id"].ToString() + "   " + czytnik["nazwa"].ToString() + "   " + czytnik["cena"].ToString() + Environment.NewLine);
            }
            czytnik.Close();
            polaczenie.Close();
        }

        catch (SqlException e)
        {
            textArea.text = e.Message;
        }

        Dispatcher.Current.BeginInvoke(() => { textArea.text = s; });
    }

    public void NapojeFromDB()
    {
        string s = "";
        string connectionString = @"Data Source=192.168.1.128;Initial Catalog=Pizzeria;Persist Security Info=True;User ID=user1;Password=bergmann1;";
        try
        {
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "select * from Drink";
            SqlDataReader czytnik = komendaSQL.ExecuteReader();
            while (czytnik.Read())
            {
                s+= czytnik["id"].ToString() + "   " + czytnik["nazwa"].ToString() + "   " + czytnik["cena"].ToString() + czytnik["pojemnosc"].ToString() + Environment.NewLine;
                //pizzas.Append(czytnik["id"].ToString() + "   " + czytnik["nazwa"].ToString() + "   " + czytnik["cena"].ToString() + Environment.NewLine);
            }
            czytnik.Close();
            polaczenie.Close();
        }

        catch (SqlException e)
        {
            textArea.text = e.Message;
        }
        Dispatcher.Current.BeginInvoke(() => { textArea.text = s; });
    }

    public void SosyFromDB()
    {
        string s = "";
        Dispatcher.Current.BeginInvoke(() => { textArea.text = ""; });
        string connectionString = @"Data Source=192.168.1.128;Initial Catalog=Pizzeria;Persist Security Info=True;User ID=user1;Password=bergmann1;";
        try
        {
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "select * from Sauce";
            SqlDataReader czytnik = komendaSQL.ExecuteReader();
            while (czytnik.Read())
            {
                s += czytnik["id"].ToString() + "   " + czytnik["nazwa"].ToString() + "   " + czytnik["cena"].ToString() + czytnik["smak"].ToString() + Environment.NewLine;
                //pizzas.Append(czytnik["id"].ToString() + "   " + czytnik["nazwa"].ToString() + "   " + czytnik["cena"].ToString() + Environment.NewLine);
            }
            czytnik.Close();
            polaczenie.Close();
        }

        catch (SqlException e)
        {
            textArea.text = e.Message;
        }
        Dispatcher.Current.BeginInvoke(() => { textArea.text = s; });
    }
}
