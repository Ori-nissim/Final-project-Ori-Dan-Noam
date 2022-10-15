using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gold;
    public TextMeshProUGUI money;

    private int moneyCount = 0;
    private int goldCount = 0;

    private
     void Awake()
    {
        // start mission time - TODO 
    }
    // Update is called once per frame
    public void updateGold()
    {
        
    }

    public void updateMoney(int amount)
    {
        moneyCount += amount;
        money.SetText(moneyCount + "");
    }
}
