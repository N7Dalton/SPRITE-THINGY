using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyScript : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public int MoneyCounter;
    public int ballMoney;
    public int goalMoney;

    // Update is called once per frame
    void Update()
    {
        //sets the TextMeshPro text to "Money: $" and then adds MoneyCounter to the end but converts it to string first
        moneyText.text = "MONEY: $" + MoneyCounter.ToString();


    }
   public void UpgradeBall()
    {

    }
}
