using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public Enemy enemy;
    public Enemy2 enemy2;
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
        if(col.gameObject.tag.Equals("Enemy") && col.gameObject.GetComponent<Enemy>() != null)
        {
            Debug.Log(col + " hit " + col.gameObject.GetComponent<Enemy>() + "! ");
            clone = Instantiate(impact, col.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);//destroy laser
            Destroy(clone,0.5f);//destroy impact after 1 second
            //Destroy(col.gameObject);
            col.gameObject.GetComponent<Enemy>().TakeDamage(damage);
        }

        if(col.gameObject.tag.Equals("Enemy") && col.gameObject.GetComponent<Enemy2>() != null )
        {
            clone = Instantiate(impact, col.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);//destroy laser
            Destroy(clone,0.5f);//destroy impact after 1 second
            col.gameObject.GetComponent<Enemy2>().TakeDamage(damage);
        }

        if(col.gameObject.name == "TopWall")
        {
            Destroy(gameObject);
        }
    }
        
    
}

