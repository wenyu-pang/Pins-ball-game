using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float mx;
    public float my;
    public float mix;
    public float miy;
    public float timeBetweenspawn;
    private float spawnTime;


    // Update is called once per frame
    void Update()
    {
        if (Time.time>spawnTime)
        {
            spawn();
            spawnTime = Time.time + timeBetweenspawn;
        }
    }   
    void spawn()
    {
        float randomx = Random.Range(mix,mx);
        float randomy = Random.Range(miy, my);
        Instantiate(obstacle, transform.position+new Vector3(randomx,randomy,0),transform.rotation);
    }
}
