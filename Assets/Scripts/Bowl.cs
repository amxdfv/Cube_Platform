using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bowl : MonoBehaviour
{

    private Rigidbody2D rb;
    public GameObject Shar;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.velocity = rb.velocity * 1.1f;
        }
        //  rb.velocity = rb.velocity * 1.1f;
        //  Vector3 Upp = new Vector3(0, 10f, 0);
        //   rb.AddForce(Upp, ForceMode2D.Impulse);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Finish"))
        {
            SceneManager.LoadScene(0);
        }
    }
}