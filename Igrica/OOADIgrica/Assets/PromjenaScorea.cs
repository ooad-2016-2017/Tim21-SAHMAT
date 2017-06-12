using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PromjenaScorea : MonoBehaviour {
    public Transform polozaj;

    public Text scoreLevelCompete;
    public Text score;
    int skor;
	// Use this for initialization
	void Start () {
        score.text = "0";
        skor = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //score.text = (polozaj.position.z+495f).ToString("0");
	}
    public void azurirajTekst(int temp)
    {
        int x = Convert.ToInt32(score.text.ToString());
        score.text = (x + temp).ToString();
        scoreLevelCompete.text = "Score: " + score.text + "/10";
        skor = Convert.ToInt32(score.text.ToString());
    }
    public int vratiScore()
    {
        int y = skor;
        return y;
    }
}
