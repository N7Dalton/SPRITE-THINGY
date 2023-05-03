using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallScript : MonoBehaviour
{
   
    public GameObject prefab;
    public MenuScript menuScript;
    public float cooldownTime = 1;
    public float nextFireTime = 0;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(nextFireTime);
        if(Time.time > nextFireTime)
        {
            //checks if you pressed the left mouse button down above the Y level 1235 which is above the red line
            if (Input.GetMouseButtonDown(0) && Input.mousePosition.y >= 1235)
            {
                nextFireTime = Time.time + cooldownTime;
                //gets a new vector3 cal pos that gets mouse position
                Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 offset = new Vector3(0, 0, 10);
                //spawns cloneball which is the prefab called circle
                GameObject cloneball = Instantiate(prefab, pos + offset, Quaternion.identity);
                //deletes it after 5 seconds so the game doesnt lag
                Destroy(cloneball, 5);
            }
        }
   
       
    }
}
