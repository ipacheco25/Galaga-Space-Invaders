using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public Enemy enemy;
    public GameObject impact;
    private GameObject clone;
    
    public float moveSpeed = 20.0f;
    public int damage = 40;

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
        Debug.Log(gameObject.name + " hit " + col.gameObject.name + "! ");


        if(col.gameObject.name == "Enemy")
        {
            clone = Instantiate(impact, col.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);//destroy laser
            Destroy(clone,0.5f);//destroy impact after 1 second
            enemy.TakeDamage(damage);
        }

        if(col.gameObject.name == "TopWall")
        {
            Destroy(gameObject);
        }
    }
        
    
}

