using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public MoneyScript moneyScript;
    public SpawnBallScript spawnBallScript;
    public CircleScript circleScript;
    public bool InMenu = false;
    public GameObject menuPanel;
   
    // Start is called before the first frame update
    void Start()
    {
        moneyScript = GameObject.Find("Money").GetComponent<MoneyScript>();
        spawnBallScript = GameObject.Find("Spawner").GetComponent<SpawnBallScript>();
        

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(InMenu);

        if (Input.GetKeyDown("space"))
        {
            if (InMenu)
            {
                InMenu = false; 
            }
            else 
            { 
                InMenu = true;
            }
           
        }
        if (InMenu)
        {
            menuPanel.SetActive(true);
           
        }
        else
        {
            menuPanel.SetActive(false);
          
        }
       
        circleScript = GameObject.Find("Circle").GetComponent<CircleScript>();
       
    }


}
