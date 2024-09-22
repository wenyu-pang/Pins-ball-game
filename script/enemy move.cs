using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    public float enemyspeed;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,enemyspeed*Time.deltaTime,0);
    }
}
