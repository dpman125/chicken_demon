using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreFunctionality : MonoBehaviour
{

    public int beans = 0;
    public int clickPower = 1;
    public int hatCost = 50;
    public int goggleCost = 100;
    public int mrBeanCost = 1000;
    public TextMeshProUGUI scoreText;
    public string scorePrefix = "Score: ";
    // Start is called before the first frame update
    void Start()
    {
        setText();
    }

    public void increaseScore()
    {
        beans = beans + clickPower;
        setText();

    }

    public void extraHat()
    {
        if(beans >= hatCost)
        {
            // clickpower increases only if funds are available
            hatCost += (hatCost / 2);
            beans = beans - hatCost;
            clickPower = clickPower + 1;
        }
        setText();
        
    }

    public void enhancedGoggles()
    {
        if (beans >= goggleCost)
        {
            // clickpower increases only if funds are available
            beans = beans - goggleCost;
            clickPower = clickPower + 5;
        }
        setText();
        
    }
    public void mrBeans()
    {
        if (beans >= mrBeanCost)
        {
            // clickpower increases only if funds are available
            beans = beans - mrBeanCost;
            clickPower = clickPower * 2;
        }
        setText();

      
    }

    void setText()
    {
        scoreText.text = scorePrefix + ": " + beans;
    }

}
