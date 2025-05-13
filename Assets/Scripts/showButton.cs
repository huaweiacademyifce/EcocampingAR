using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showButton : MonoBehaviour
{
    public GameObject BotaoStartMandarim;
    public GameObject BotaoStartIngles;

    public void MostrarBotaoMandarim()
    {

        BotaoStartMandarim.SetActive(true);
        BotaoStartIngles.SetActive(false);
    }

    public void MostrarBotaoIngles()
    {
        BotaoStartIngles.SetActive(true);
        BotaoStartMandarim.SetActive(false);
    }
}
