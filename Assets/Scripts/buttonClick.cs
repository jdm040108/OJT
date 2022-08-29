using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ingingq()
    {
        if (GameManager.instance.isSteak)
        {
            GameManager.instance.myGold += 140;
            GameManager.instance.myReputation += 1;
            GameManager.instance.isSteak = false;
            GameManager.instance.isPizza = true;
        }
        else
        {
            GameManager.instance.myReputation -= 1;
        }
    }
    public void ingingw()
    {
        if (GameManager.instance.isPizza)
        {
            GameManager.instance.myGold += 140;
            GameManager.instance.myReputation += 1;
            GameManager.instance.isPizza = false;
            GameManager.instance.isHotdog = true;
        }
        else
        {
            GameManager.instance.myReputation -= 1;
        }
    }
    public void inginge()
    {
        if(GameManager.instance.isHotdog)
        {
        GameManager.instance.myGold += 140;
        GameManager.instance.myReputation += 1;
            GameManager.instance.isHotdog = false;
            GameManager.instance.isFries = true;
        }
        else
        {
            GameManager.instance.myReputation -= 1;
        }
    }
    public void ingingr()
    {
        if (GameManager.instance.isFries)
        {
            GameManager.instance.myGold += 140;
            GameManager.instance.myReputation += 1;
            GameManager.instance.isFries = false;
            GameManager.instance.isSteak = true;
        }
        else
        {
            GameManager.instance.myReputation -= 1;
        }
    }
}
