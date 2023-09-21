using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    static int MAX_HP = 100;
        
    string name;
    int HP;
    private int hP;

    public Player(string name, int HP) 
    {
        this.name = name;
        HP = hP;
    
    }
    public Player()
    {
    HP = MAX_HP;
    }
    public void DoDamage(int damage)
    {
        HP -= damage;
        if(HP < 0) HP = 0;
    }
    public void Heal(int healing)
    {
        HP += healing;
       /// if()
    }


}


