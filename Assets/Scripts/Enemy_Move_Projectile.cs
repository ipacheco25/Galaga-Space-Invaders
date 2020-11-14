using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move_Projectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    //public GameObject player;
    public GameObject enemy_impact;
    GameObject clone;
    public Player player;
    public int damage = 10;

    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(0,-1) * moveSpeed;
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("Hit " + col.gameObject.name + "! ");
            /*
            col.gameObject.SetActive(false);
            clone = Instantiate(explosion, gameObject.transform.position,gameObject.transform.rotation);
            Destroy(clone,1);
            */
            
            clone = Instantiate(enemy_impact, col.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);//destroy enemy laser
            Destroy(clone,0.5f);//destroy enemy_impact after 1 second
            player.TakeDamage(damage);
        }

        if(col.gameObject.name == "BottomWall")
        {
            Debug.Log("Hit " + col.gameObject.name + "! ");
            Destroy(gameObject);
        }
    }
}