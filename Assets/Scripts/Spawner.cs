using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject player;
    float timebtwspawn;
    float current;
    //public GameObject menu;
    void Start()
    {
        //menu.active = false;
        timebtwspawn = 0.5f;
        current = timebtwspawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.active = true)
        {
            current -= Time.deltaTime;
            int rand = Random.Range(0, enemies.Length);
            if (current <= 0f)
            {
                Instantiate(enemies[rand], enemies[rand].transform.position, enemies[rand].transform.rotation);
                current = timebtwspawn;
            }
        }
        else if(player.active=false)
        {
            //menu.active = true;
            
             
        }
    }
}
