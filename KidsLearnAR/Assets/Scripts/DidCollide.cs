using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DidCollide : MonoBehaviour
{

    private string[] colors = { "Red Cube", "Blue Cube", "White Cube" };
    private int randNum;
    public Text text;
    private string goalCube;
    public int score = 0;
    public Text scoreText;

    private void Start()
    {
        randNum = Random.Range(0, colors.Length);
        goalCube = colors[randNum];
        Debug.Log(goalCube);
        text.text = "Run to the " + goalCube;
        scoreText.text = score.ToString();
    }

    private void Update()
    {
        //testing
        if (Input.GetKeyDown(KeyCode.S))
        {
            score += 10;
            scoreText.text = score.ToString();
        }   
    }


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == goalCube)
        {
            text.text = "Correct! That is the " + goalCube + "!";
            Debug.Log(goalCube);

            score += 10;
            scoreText.text = score.ToString();
        }
        else
        {
            text.text = "Nope! That's the " + collision.tag + ".  Try again!";
            score -= 1;
            scoreText.text = score.ToString();
        }

        if(collision.tag == "Red Cube")
        {
            Debug.Log("Red Cube");
        }
        else if(collision.tag == "Blue Cube")
        {
            Debug.Log("Blue Cube");
        }
        else if(collision.tag == "White Cube")
        {
            Debug.Log("White Cube");
        }
    }

    
}
