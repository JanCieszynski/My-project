using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //czas do zakonczenia poziomu
    public float timeLeft = 90f;

    //elementy UI
    public GameObject timeCounter;
    public GameObject gameOverLay;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //zmniejsz ilosc czasu pozosta³ego na wykonanie poziomu
        //o czas, który min¹³ od ostaniej klatki
        timeLeft -= Time.deltaTime;



        //aktualizuj UI
        UpdateUI();
    }

    void UpdateUI()
    {
        //funkcja odpowiedzialna za aktualizacjê interfejsu u¿ytkownika

        timeCounter.GetComponent<TextMeshProUGUI>().text = "Pozostały czas:" + Mathf.Floor(timeLeft).ToString();

        if(timeLeft <= 0)
            gameOverLay.SetActive(true);
    }
    public void onWin()
    {
        //jezeli wygramy
        gameOverLay.SetActive(true);
        gameOverLay.transform.Find("GameOverText").GetComponent<TextMeshProUGUI>().text = "WYGRAŁEŚ!";
    }
    public void OnLose()
    {
        //jezeli przegramy
        gameOverLay.SetActive(true);
        gameOverLay.transform.Find("GameOverText").GetComponent<TextMeshProUGUI>().text = "Zostałeś namierzony przez kamere!";
    }
}
