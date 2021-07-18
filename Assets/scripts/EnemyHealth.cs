using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject deadEff;
    Vector3 tr ; 

    void Update()
    {
        if (gameObject.transform.position.y < -7)
        {
            Destroy(gameObject);
        }

    }

    public void Die(){
        tr = new Vector3(transform.position.x, transform.position.y-1,transform.position.z);
        Instantiate (deadEff, tr, Quaternion.identity);
        Destroy(gameObject);
    }
}
