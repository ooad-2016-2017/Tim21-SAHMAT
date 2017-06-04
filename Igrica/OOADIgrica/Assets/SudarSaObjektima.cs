using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SudarSaObjektima : MonoBehaviour {

    public KretnjaIgraca kretnja;
    public PromjenaScorea ps;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnCollisionEnter(Collision info)
    {
        if (info.collider.tag == "Objekti")
        {
            kretnja.enabled = false;
            FindObjectOfType<GameManager>().KrajIgre();
        }
        
    }
}
