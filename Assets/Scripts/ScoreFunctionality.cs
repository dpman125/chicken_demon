using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreFunctionality : MonoBehaviour
{

    public class powerUpgrades
    {
        const int roundHouseKick = 10;
        const int backKick = 25;
        const int frontKick = 50;
        const int jumpingFrontKick = 100;
    }

    public class dodgeUpgrades
    {
        const int highBlock = 10;
        const int lowBlock = 20;
        const int knifeHandBlock = 50;
        const int circularBlock = 100;
    }

    public class dummyUpgrades
    {
        const int lightDummy = 1;
        const int medDummy = 5;
        const int strongDummy = 10;
        const int superStrongDummy = 15;
    }

    public class meditationTechniques
    {
        const int layingDown = 1;
        const int corpsPose = 2;
        const int Padmasana = 5;
        const int vajrasana = 10;
        const int treePose = 15;
        const int floatingPadmasana = 25;
    }

    public int beans = 0;
    public int clickPower = 1;
    public int hatCost = 50;
    public int goggleCost = 100;
    public int mrBeanCost = 1000;
    public TextMeshProUGUI scoreText;
    public string scorePrefix = "Score: ";
    public Animator playerAnim;
    public Animation kick;
    // Start is called before the first frame update
    void Start()
    {
        setText();
    }

    public void increaseScore()
    {
        beans = beans + clickPower;
        setText();
        playerAnim.Play("Kick");

    }

    public void extraHat()
    {
        if(beans >= hatCost)
        {
            // clickpower increases only if funds are available
            beans -= hatCost;
            clickPower = clickPower + 1;
            hatCost += (hatCost / 2);
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
            goggleCost += (goggleCost / 2);
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
            mrBeanCost += (mrBeanCost / 2);
        }
        setText();

      
    }

    void setText()
    {
        scoreText.text = scorePrefix + ": " + beans;
    }
}

public class ResetDidClickOnExit : StateMachineBehaviour
{
    // Called when the animation state exits
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("DidClick", false);
    }
}
