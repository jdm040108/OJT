using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI gold;
    public TextMeshProUGUI repu;

    public GameObject Pizza;
    public GameObject HotDog;
    public GameObject Fries;
    public GameObject Steak;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gold.text = "Gold :"+GameManager.instance.myGold.ToString();
        repu.text = "Reputation :" + GameManager.instance.myReputation.ToString();

        if(GameManager.instance.isFries)
        {
            Fries.SetActive(true);
            HotDog.SetActive(false);
            Pizza.SetActive(false);
            Steak.SetActive(false);
        }
        if (GameManager.instance.isHotdog)
        {
            Fries.SetActive(false);
            HotDog.SetActive(true);
            Pizza.SetActive(false);
            Steak.SetActive(false);
        }
        if (GameManager.instance.isPizza)
        {
            Fries.SetActive(false);
            HotDog.SetActive(false);
            Pizza.SetActive(true);
            Steak.SetActive(false);
        }
        if (GameManager.instance.isSteak)
        {
            Fries.SetActive(false);
            HotDog.SetActive(false);
            Pizza.SetActive(false);
            Steak.SetActive(true);
        }
    }
}
