using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EthanKretnja : MonoBehaviour {

    public Rigidbody silaIgraca;
    bool skocio = false;
    // Update is called once per frame
    void Update()
    {
       silaIgraca.AddForce(0, 0, 200 * Time.deltaTime);
        /*if (Input.GetKey("d"))
        {
            silaIgraca.AddForce(60 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            silaIgraca.AddForce(-60 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }*/
     /*   if (Input.GetKey(KeyCode.Space))
        {
            if (!skocio)
            {
                silaIgraca.AddForce(0, 150, 0);
                skocio = true;
            }

        }*/
        if (silaIgraca.position.y < -1f)
        {
            FindObjectOfType<GameManager>().KrajIgre();
        }
        if (silaIgraca.position.y == 1)
        {
            skocio = false;
        }
    }
}
