using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Xml;


public class GameManager : MonoBehaviour

   
{ 
    public Player player;
    public GameObject gameUI;

    public TMP_Text display;
    public TMP_Text option1;
    public TMP_Text option2;
    public TMP_Text option3;
   
   
    
    int location;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        player = new Player();
        location = 0;
        ToStart();

    }
    public void ToStart()
    {
        display.text = GameData.descriptions[0];
        option1.text = GameData.options[0,0];
        option2.text = GameData.options[0,1];
        option3.text = GameData.options[0,2];
    }
    public void GoToLocation(int newLoc) 
    {
        location = newLoc;
        display.text = GameData.descriptions[location];
        option1.text = GameData.options[location, 0];
        option2.text = GameData.options[location, 1];
        option3.text = GameData.options[location, 2];
    }
    public void GoToEnding(int v)
    {
        display.text = GameData.endingdescriptions[0];
        display.text = GameData.endingdescriptions[1];
        display.text = GameData.endingdescriptions[2];
        option1.text = GameData.endings[0, 0];
        option2.text = GameData.endings[0, 1];
        option3.text = GameData.endings[2, 2];
    }
    public void optionSelected(int index)//button choices
    {
        Debug.Log("AAAAAAAAAAAAAA " + location);
        if (location == 0)
        {
            if (index == 0)
            {
                Debug.Log("L0Ent" + location);
                GoToLocation(1);

            }
            else if (index == 1)//room
            {
                GoToEnding(0);
                location = 2;
            }
            else if (index == 2)
            {
                Debug.Log("L2Ent" + location);
                GoToEnding(1);
                location = 2;
            }

        }
        else if (location == 1)
        {
            if (index == 0)
            {
                Debug.Log("HIYAATTT!" + location);
                GoToLocation(2);
                location = 2;
            }
            else if (index == 1)
            {
                Debug.Log("nope.avi" + location);
            }
            else if (index == 2)
            {
                Debug.Log("*insert filthy frank joke*" + location);
                GoToEnding(2);
                location = 2;
            }
        }
        
        else if (location == 2)
        {
            if (index == 0)
            {
                Debug.Log("Goodbye Segen");
                EndGame();
            }
            else if (index == 1)
            {
                Debug.Log("/tp player menu");
                SceneManager.LoadScene("Menu");
            }
            else if (index == 2)
            {
                Debug.Log("Here we GOOO!");
                GoToLocation(0);
            }
        }
    }
    public void EndGame()
    {
        Debug.Log("Game Over " + location);
         Application.Quit();
    }


}
