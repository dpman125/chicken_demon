using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour
{

    public GameObject fireBall;
    public int direction = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireRoutine());
    }

    // Update is called once per frame
    void Update()
    {


    }

    IEnumerator FireRoutine()
    {
        while (true)
        {
            Instantiate(fireBall, transform.position, transform.rotation);
            yield return new WaitForSeconds(1f); // Wait for 1 second
        }
    }

    IEnumerator attackPattern1()
    {
        Instantiate(fireBall, transform.position, transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(fireBall2, transform.position, transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instatniate(fireBall4,  transform.position, transform.rotation);
        yield return new WaitForSeconds(.5f);
    }
}
