using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NoviLevel : MonoBehaviour {

    public void UcitajSljedeciNivo()
    {
        int x = 0;
        Debug.Log("Nivo ucitan");
        x = FindObjectOfType<PromjenaScorea>().vratiScore();
        FindObjectOfType<ZadnjiScore>().postaviScore(x);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
