using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    int score = 0;
    public Text scoreText;
    public int numberOfbricks;
    // Start is called before the first frame update
    void Start()
    {
        numberOfbricks = GameObject.FindGameObjectsWithTag("brick").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncrementScore()
    {
        score = score + 10;
        scoreText.text = "Score : " + score;
    }
    public void updatenumberofbricks()
    {
        numberOfbricks--;
        if(numberOfbricks<=0)
        {
            SceneManager.LoadScene("level2");
        }
    }
  
}
