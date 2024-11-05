using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************
 * This is allows the camera to follow the player. 
 * It is attached to the Camera
 * 
 * Daniel
 * 11/1/2024
 ****************************************************/

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
