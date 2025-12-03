using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour
{

    public GameObject[] fireBall;
    public int direction = 0;
    // Start is called before the first frame update
    void Start()
    {
        

        //StartCoroutine(attackPattern1());
        StartCoroutine(StartRandomizer());
         
    }
    IEnumerator StartRandomizer()
    {
        while (true)
        {
            randomizer();
            yield return new WaitForSeconds(2f);
        }
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void randomizer()
    {
        int rand = Random.Range(0, 3);
        // random number between 0 and 1
        if (rand == 1)
        {
            StartCoroutine(attackPattern1());
            
        }
        else if (rand == 2)
        {
            StartCoroutine(attackPattern2());
        }
        else
        {
            StartCoroutine(attackPattern3());
        }
    }
    IEnumerator FireRoutine()
    {
        while (true)
        {
            Instantiate(fireBall[1], transform.position, transform.rotation);
            yield return new WaitForSeconds(1f); // Wait for 1 second
        }
    }

    // IEnumerator is a function that can pause its execution and return control to Unity but then continue where it left off on the following frame.
    IEnumerator attackPattern1()
    {
       
            Instantiate(fireBall[0], transform.position, transform.rotation);
            yield return new WaitForSeconds(.5f);
            Instantiate(fireBall[1], transform.position, transform.rotation);
            yield return new WaitForSeconds(.5f);
            Instantiate(fireBall[2], transform.position, transform.rotation);
            yield return new WaitForSeconds(.5f);
            Instantiate(fireBall[3], transform.position, transform.rotation);
            
            
       
    }
    IEnumerator attackPattern2()
    {
        
            Instantiate(fireBall[0], transform.position, transform.rotation);
            Instantiate(fireBall[3], transform.position, transform.rotation);
            yield return new WaitForSeconds(.7f);
            Instantiate(fireBall[1], transform.position, transform.rotation);
            Instantiate(fireBall[2], transform.position, transform.rotation);
         
    }
    IEnumerator attackPattern3()
    {
        
            Instantiate(fireBall[2], transform.position, transform.rotation);
            yield return new WaitForSeconds(.4f);
            Instantiate(fireBall[2], transform.position, transform.rotation);
            yield return new WaitForSeconds(.4f);
            Instantiate(fireBall[3], transform.position, transform.rotation);
            yield return new WaitForSeconds(.4f);
            Instantiate(fireBall[1], transform.position, transform.rotation);
            Instantiate(fireBall[1], transform.position, transform.rotation);
            Instantiate(fireBall[1], transform.position, transform.rotation);
           
       
    }
}
