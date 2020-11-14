using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public GameObject enemy;
    public GameObject explosion;
    GameObject clone;
    
    public float moveSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(0,1) * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hit " + col.gameObject.name + "! ");


        if(col.gameObject.name == "Enemy")
        {
            
            Destroy(col.gameObject);
            clone = Instantiate(explosion, gameObject.transform.position,gameObject.transform.rotation);
            Destroy(clone,1);
            
        }

        if(col.gameObject.name == "TopWall")
        {
            Destroy(gameObject);
        }
    }
        
    
}
