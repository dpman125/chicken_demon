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
        StartCoroutine(attackPattern1());
    }

    // Update is called once per frame
    void Update()
    {


    }

    IEnumerator FireRoutine()
    {
        while (true)
        {
            Instantiate(fireBall[1], transform.position, transform.rotation);
            yield return new WaitForSeconds(1f); // Wait for 1 second
        }
    }

    IEnumerator attackPattern1()
    {
        while (true)
        {
            Instantiate(fireBall[0], transform.position, transform.rotation);
            yield return new WaitForSeconds(.5f);
            Instantiate(fireBall[1], transform.position, transform.rotation);
            yield return new WaitForSeconds(.5f);
            Instantiate(fireBall[2], transform.position, transform.rotation);
            yield return new WaitForSeconds(.5f);
            Instantiate(fireBall[3], transform.position, transform.rotation);
            yield return new WaitForSeconds(.5f);
        }
    }
}
