using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovements : MonoBehaviour
{
    // Start is called before the first frame update
    public float cameraspeed;





        // Update is called once per frame
        void Update()
        {
        transform.position += new Vector3(0,cameraspeed * Time.deltaTime, 0);
        }
    
}