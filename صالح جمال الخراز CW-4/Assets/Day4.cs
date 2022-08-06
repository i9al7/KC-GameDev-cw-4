using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day4 : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public int inc = 1;
    public Text incText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scoreUp()
    {
        score += inc;
        scoreText.text = score.ToString();
    }
    public void shop()
    {
        if(score >= 10)
        {
            score -= 10;
            inc += 1;
            scoreText.text = score.ToString();
            incText.text = "Inc : " + inc;
        }
    }
    public void shop2()
    {
        if (score >= 50)
        {
            score -= 50;
            inc += 5;
            scoreText.text = score.ToString();
            incText.text = "Inc : " + inc;
        }
    }
    public void restart()
    {
        score = 0;
        inc = 1;
        scoreText.text = score.ToString();
        incText.text = "Inc : " + inc;
    }
}
