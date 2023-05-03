using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    public MoneyScript moneyScript;
    public AudioSource audioSource;
    [SerializeField] public GameObject floatingTextPrefab;
    [SerializeField] public GameObject FinishLineTextPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //gets money script from the text in game called money
        moneyScript = GameObject.Find("Money").GetComponent<MoneyScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the ball collides with anything with the tag "Block" it will-
        //start the method FloatingNum
        //add 1 to the int MoneyCounter in the moneyScript
        //Play the audio connected to the ball

        if (collision.gameObject.tag == "Block")
        {
            FloatingNum();
            moneyScript.MoneyCounter += moneyScript.ballMoney;
            audioSource.Play();
        }     
    }
    public void FloatingNum()
    {
        //checks if floatingTextPrefab isnt null in the inspector
        if (floatingTextPrefab)
        {
            //spawns text
            GameObject prefab = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity);
            //after two seconds the animation is over so it can be deleted so that it doesnt lag the game
            //destroys text after 2 seconds 
            Destroy(prefab, 2);
        }
    }
    public void FloatingGoalNum()
    {
        //checks if floatingTextPrefab isnt null in the inspector
        if (FinishLineTextPrefab)
        {
            //spawns text
            GameObject prefab2 = Instantiate(FinishLineTextPrefab, transform.position, Quaternion.identity);
            //after two seconds the animation is over so it can be deleted so that it doesnt lag the game
            //destroys text after 2 seconds 
            Destroy(prefab2, 2);
        }
    }
}