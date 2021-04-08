using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SG : MonoBehaviour {

    GameObject pn ;
    GameObject BS ;
    GameObject BE ;
    GameObject BR ;

    // Use this for initialization
    void Start () {
         pn = GameObject.Find("PanelRules") as GameObject;
         BS = GameObject.Find("ButtonStart") as GameObject;
         BE = GameObject.Find("ButtonExit") as GameObject;
         BR = GameObject.Find("ButtonRules") as GameObject;
        pn.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void GameRules()
    {
        BS.SetActive(false);
        BE.SetActive(false);
        BR.SetActive(false);
               
        pn.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void RulesBack()
    {
        BS.SetActive(true);
        BE.SetActive(true);
        BR.SetActive(true);

        pn.SetActive(false);
    }
}
