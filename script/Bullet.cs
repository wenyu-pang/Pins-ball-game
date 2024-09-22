using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject enemy;
    public int damage = 20;

    // Start is called before the first frame update
    private void Start()
    {
        rb.velocity = transform.up * speed;
    }
    //when it hit something will give you the resolve
    private void OnTriggerEnter2D(Collider2D hit) {
        Enemy e = hit.GetComponent<Enemy>();
        if (e!=null)
        {
            e.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
        
    


}
