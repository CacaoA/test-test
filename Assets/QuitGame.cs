using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class QuitGame : MonoBehaviour
{
    public void ExitClick()
    {
        Debug.Log("ENDGAME");
        Application.Quit();
    }
}
