using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    //variable thingies
    public MoneyScript moneyScript;
    public SpawnBallScript spawnBallScript;
    public CircleScript circleScript;
    public int goalPoints = 1;
    // Start is called before the first frame update
    void Start()
    {
        //Gets the money text and gets the MoneyScript component
        moneyScript = GameObject.Find("Money").GetComponent<MoneyScript>();
        spawnBallScript = GameObject.Find("Spawner").GetComponent<SpawnBallScript>();
    }
    //detects if this game object is triggered (2D version)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Adds money to the int in the script "MoneyScript"
        moneyScript.MoneyCounter += goalPoints;
        //calls method FloatingNum from the circle Script
        circleScript.FloatingNum();
    }
}
