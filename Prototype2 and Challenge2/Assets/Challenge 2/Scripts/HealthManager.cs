/*
 * Luke Lesimple
 * Challenge 2
 * Health and Score management
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Text textbox;
    public GameObject gameOverText;
    public int maxhealth = 5;
    public int health;
    public int score;
    private bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score +"\nHealth: " + health;
        if(health <= 0 || score >= 5)
        {
            gameOver = true;
            gameOverText.SetActive(true);

            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }

    public void takeDamage()
    {
        health--;
    }
    public void gainScore()
    {
        score++;
    }
}
