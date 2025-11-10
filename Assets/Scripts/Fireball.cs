using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    public Vector3 target = new Vector3(-6.9f, -3.11f);


    public enemyFire enemyFireScript;
    public int speed;
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(destroyFireBall());
    }

    // Update is called once per frame
    void Update()
    {

                Vector3 direction = (target - transform.position).normalized;
                // Move towards the target
                transform.position += direction * speed * Time.deltaTime;
        
    }

    IEnumerator destroyFireBall() {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);

    }

}
