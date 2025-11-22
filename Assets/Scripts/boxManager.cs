using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxManager : MonoBehaviour
{

    public GameObject[] playerBoxes;
    public GameObject[] child;
    public GameObject selfChild;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < playerBoxes.Length; i++)
        {
            child[i].SetActive(false);
        }
        child[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        Debug.Log("mouse is over");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse is clicked");
            for(int i = 0; i < playerBoxes.Length; i++)
            {
                child[i].SetActive(false);
                
            }
            selfChild.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision == tag)
    }

}
