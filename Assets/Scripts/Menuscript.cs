﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuscript : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("Game");
    }

    public void exitgame()
    {
        Application.Quit();
    }
}
