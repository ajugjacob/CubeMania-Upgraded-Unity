using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offsetPosition = new Vector3(0,3,-5);


    void Update()
    {
        transform.position = player.position + offsetPosition;
    }
}
