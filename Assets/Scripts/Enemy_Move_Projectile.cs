using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move_Projectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public GameObject playership;
    public GameObject explosion;
    GameObject clone;

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
            col.gameObject.SetActive(false);
            clone = Instantiate(explosion, gameObject.transform.position,gameObject.transform.rotation);
            Destroy(clone,1);
            
        }

        if(col.gameObject.name == "BottomWall")
        {
            Debug.Log("Hit " + col.gameObject.name + "! ");
            Destroy(gameObject);
        }
    }
}