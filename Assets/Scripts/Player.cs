using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 100;
    public float moveSpeed; 
    public Rigidbody2D rb;
    Vector2 movement;
    private GameObject explosion_clone;
    public GameObject explosion;

    // Update is called once per frame
    void Update()
    {
        //player movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical"); 
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);   
    }

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("Player taking damage");
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
        explosion_clone = Instantiate(explosion, GameObject.FindGameObjectWithTag("Player").transform.position,GameObject.FindGameObjectWithTag("Player").transform.rotation);
        Destroy(GameObject.FindGameObjectWithTag("Player")); 
        Destroy(explosion_clone,1);
    }

    

}
