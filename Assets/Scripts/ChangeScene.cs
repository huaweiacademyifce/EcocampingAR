using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MudarCena(String cena)
    {
        SceneManager.LoadScene(cena);
    }
}
