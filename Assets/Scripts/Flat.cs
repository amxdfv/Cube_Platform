using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flat : MonoBehaviour {

    private Rigidbody2D rb;
    public GameObject Brik;

    // Use this for initialization
    void Start () {
		rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        MoveFlat();
	}

    void MoveFlat()
    {
        if (Input.GetKey(KeyCode.A))
        {

            // rb.AddForce(Vector2.left*50f, ForceMode2D.Impulse);
             Brik.transform.Translate(Vector2.left*150f*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
           // rb.AddForce(Vector2.right * 50f,ForceMode2D.Impulse);
            Brik.transform.Translate(Vector2.right * 150f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MaimMenu");
        }
    }

    



}
