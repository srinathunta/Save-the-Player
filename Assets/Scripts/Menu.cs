using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text HighScore;
    void Start()
    {
        
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void play()
    {
        Score.scoreValue = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ResetScore()
    {
        Score.scoreValue = 0;
        HighScore.text = "0";
        PlayerPrefs.DeleteKey("HighScore");
        
    }
    public void Quit()
    {
        Application.Quit();
    }
}
