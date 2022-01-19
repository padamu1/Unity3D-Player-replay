using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    new Transform transform;
    void Start()
    {
        transform = this.GetComponent<Transform>();
    }
    void LateUpdate()
    {
        transform.position = new Vector3 (-1,1,-1) + player.position;
    }
}
