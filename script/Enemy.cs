using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Enemy : MonoBehaviour

{
    private GameObject player;
    public int health = 100;
 
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
      
    }
    //when the enemy health going to 0
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health<=0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
      //  else if (collision.tag == "bullet")
       // {
        //  Destroy(this.gameObject);
        //}
    }
}
