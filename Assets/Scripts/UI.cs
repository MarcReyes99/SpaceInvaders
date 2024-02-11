using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public int punt;
    public TMP_Text puntuacion;
    public int life;
    public TMP_Text lifes;
    public GameObject gameOver;
    public GameObject youWon;

    private void Start()
    {
        gameOver.SetActive(false);
        youWon.SetActive(false);
    }

    void Update()
    {
        puntuacion.text = punt.ToString();
        lifes.text = life.ToString();
        if (punt >= 1000)
        {
            punt = 1000;
            Time.timeScale = 0;
            youWon.SetActive(true);
        }

        if (life <= 0)
        {
            life = 0;
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
    }
}