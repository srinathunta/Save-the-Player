using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    float movingSpeed = 10f;
    public GameObject menu;
    public AudioSource GO;
    void Start()
    {
        menu.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-movingSpeed *Time.deltaTime, 0f,0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(movingSpeed * Time.deltaTime, 0f, 0f));
        }
        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, -10f, 10f),
            transform.position.y);
    }
    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag=="Enemy")
    //    {
    //        menu.active = true;

    //        GO.Play();
    //    }
        
    //    //ball.GetComponent<Rigidbody2D>();
    //    //gameover.text = "GAME OVER";
    //    //if (Score.scoreValue > PlayerPrefs.GetInt("HighScore", 0))
    //    //{
    //    //    gameover.text = "CONGRATULATIONS\n\tGAME OVER";
    //    //}

    //    Score.scoreValue -= 1;
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            menu.active = true;
            GO.Play();
        }
        

        
    }

}
