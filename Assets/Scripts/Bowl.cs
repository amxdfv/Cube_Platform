using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bowl : MonoBehaviour
{
   public  GameObject WP;
    private Rigidbody2D rb;
    public GameObject Shar;

    // Use this for initialization
    void Start()
    {
        WP.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float speed = Math.Abs(rb.velocity.x) + Math.Abs(rb.velocity.y);   // calculate speed
        if (speed < 100)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                rb.velocity = rb.velocity * 1.5f;
            }
            else
            {
                rb.velocity = rb.velocity * 1.02f;
            }
         //   Debug.Log(speed);
        } else
        {
          //  Debug.Log("Ограничение");
        }
        WinCount();
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Stage1");
        }
    }

    void WinCount()
    {
      GameObject[] WinRate = GameObject.FindGameObjectsWithTag("Cube");
        if (WinRate.Length == 0)
        {
            WP.SetActive(true);
            rb.constraints = RigidbodyConstraints2D.FreezePosition;

        }
    }


}