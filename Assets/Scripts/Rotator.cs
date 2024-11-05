using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************
 * This is used to rotate the collectibles.  
 * It is attached to the Collectibles
 * 
 * Daniel
 * 11/1/2024
 ****************************************************/

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime);

    }
}
