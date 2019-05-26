using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

   
    
    //public Menu menu;
    //public GameObject menu;
    //public Spawner spawn;
    private void Start()
    {
        //menu.active = false;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "Player")
        {

        //    menu.active = true;
            Destroy(collision.gameObject);
        //    //GO.Play();
        }
        if (collision.collider.tag == "Ground")
        {
            
            Score.scoreValue += 1;
            
            Destroy(this.gameObject);
            
        }
    }
   
}
