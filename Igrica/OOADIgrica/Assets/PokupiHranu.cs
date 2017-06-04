using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokupiHranu : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter()
    {        
        FindObjectOfType<PromjenaScorea>().azurirajTekst(1);
        
    }
}
