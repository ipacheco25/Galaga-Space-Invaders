using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public Rigidbody2D enemy_rb;
    public float moveSpeed = 15.0f;
    public int health = 100;

    public GameObject enemy;
    public GameObject explosion;
    private GameObject explosion_clone;
    private GameObject enemy_clone;

    

    public bool changeDirection = false;

    // Start is called before the first frame update
    void Start()
    {
        enemy_rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
    }

    public void moveEnemy()
    {
        if (changeDirection == true){
            enemy_rb.velocity = new Vector2(1,0) * -1 * moveSpeed;
        } else if (changeDirection == false){
            enemy_rb.velocity = new Vector2(1,0) * moveSpeed;
        } 
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "RightWall"){
            Debug.Log("Hit the right wall!");
            changeDirection = true;
        }

        if(col.gameObject.name == "LeftWall"){
            Debug.Log("Hit the left wall!");
            changeDirection = false;
        }
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("TakeDamage()");
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
        
    }

    void Die()
    {
        Debug.Log("Called Die()");
        //enemy_clone = Instantiate(enemy, gameObject.transform.position,gameObject.transform.rotation);
        explosion_clone = Instantiate(explosion, gameObject.transform.position,gameObject.transform.rotation);
        Destroy(gameObject);
        Destroy(explosion_clone,1);  
    }
    
}
