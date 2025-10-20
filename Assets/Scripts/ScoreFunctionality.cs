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

    // general stats
    public int coins = 0;
    public int clickPower = 1;
    public int passiveCoins = 0;
    public int strength = 0;
    public int endurance = 0;
    public int reflex = 0;
    public int meditation = 0;

    // costs
    public int meditationCost = 50;
    public int strengthCost = 100;
    public int enduranceCost = 100;
    public int reflexCost = 100;


    // text
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI medText;
    public TextMeshProUGUI strText;
    public TextMeshProUGUI endrText;
    public TextMeshProUGUI rflxText;
    public TextMeshProUGUI medCostText;
    public TextMeshProUGUI strCostText;
    public TextMeshProUGUI endrCostText;
    public TextMeshProUGUI rflxCostText;
    public float coinProgress = 0;

    public Animator playerAnim;
    public Animation kick;
    // Start is called before the first frame update
    void Start()
    {
        setText();
    }

    private void Update()
    {
        coinProgress += passiveCoins * Time.deltaTime;

        if (coinProgress >= 1f)
        {
            int coinsToAdd = Mathf.FloorToInt(coinProgress);
            coins += coinsToAdd;
            coinProgress -= coinsToAdd;
            setText();
        }
        setText();
    }

    public void increaseCoins()
    {
        coins += clickPower;
        playerAnim.Play("Kick");
    }

    public void meditationUpgrade()
    {
        if(coins >= meditationCost)
        {
            // clickpower increases only if funds are available
            coins -= meditationCost;
            passiveCoins++;
            meditation++;
            meditationCost += (meditationCost / 4);
        }
        
    }

    public void strengthUpgrade()
    {
        if (coins >= strengthCost)
        {
            strength++;
            coins -= strengthCost;
            clickPower ++;
            strengthCost += (strengthCost / 3);
        }
        
    }
    public void enduranceUpgrade()
    {
        if (coins >= enduranceCost)
        {
            // clickpower increases only if funds are available
            coins -= enduranceCost;
            endurance++;
            enduranceCost += (enduranceCost / 3);
        }

      
    }
    public void reflexUpgrade()
    {
        if (coins >= reflexCost)
        {
            // clickpower increases only if funds are available
            coins -= enduranceCost;
            reflex++;
            reflexCost += (reflexCost / 3);
        }


    }

    void setText()
    {
        coinText.text = coins.ToString();
        medText.text = "zen: " + meditation;
        strText.text = "strength: " + strength;
        endrText.text = "endurance: " + endurance;
        rflxText.text = "reflex: " + reflex;
        medCostText.text = "$"+ meditationCost.ToString();
        strCostText.text = "$" + strengthCost.ToString();
        endrCostText.text = "$" + enduranceCost.ToString();
        rflxCostText.text = "$" + reflexCost.ToString();
    }
    public void restartGame()
    {
    coins = 0;
    clickPower = 1;
    passiveCoins = 0;
    strength = 0;
    endurance = 0;
    reflex = 0;
    meditation = 0;

    // costs
    meditationCost = 50;
    strengthCost = 100;
    enduranceCost = 100;
    reflexCost = 100;
}


}

