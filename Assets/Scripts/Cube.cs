using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    public int live;
    GameObject GO;
    public Text cap;

    // Use this for initialization
    void Start()
    {
        GO = this.gameObject;
        LifeDisplay();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LifeDisplay()
    {
        cap.text = live.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (live < 1)
        {
            Destroy(GO);
        } else
        {
            live = live - 1;
            LifeDisplay();
        }
    }
}