using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int live;
    GameObject GO;

    // Use this for initialization
    void Start()
    {
        GO = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (live < 1)
        {
            Destroy(GO);
        } else
        {
            live = live - 1;
        }
    }
}