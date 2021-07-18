using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet1 : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void update(){
         PlayerRaycast();
    }
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        
        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy !=null){
            enemy.Die();
            Destroy(gameObject);
        }

        if ( hitInfo.name != null & hitInfo.name != "characters_23"){
            Destroy(gameObject);
        }
    }
    
    void PlayerRaycast()
    {
        RaycastHit2D rayUp = Physics2D.Raycast(transform.position, Vector2.up);
        if(rayUp!=null&&rayUp.collider != null)
        {
            Destroy(gameObject);
        }

    }
}
