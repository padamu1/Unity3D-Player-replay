using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    new Transform transform;
    private Queue<Vector3> replayPosition;
    private bool replay;
    private float timer;
    private float replayTimer;
    void Awake()
    {
        replayPosition = new Queue<Vector3>();
        replay = false;
        timer = 0f;
        replayTimer = 0f;
    }
    void Start()
    {
        transform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!replay)
        {
            timer += Time.deltaTime;
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, 1) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, 0, -1) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-1, 0, 0) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.R))
            {
                replay = true;
                Debug.Log(timer);
            }
            // used Update for replay

            //replayPosition.Enqueue(transform.position);
        }
        /*
        else
        {
            replayTimer += Time.deltaTime;
            if (replayPosition.Count == 0)
            {
                replay = false;
                Debug.Log(replayTimer);
            }
            else
            {
                transform.position = replayPosition.Dequeue();
            }
        }
        */
        
    }
    // used FixedUpdate for replay
    
    void FixedUpdate()
    {
        if (!replay)
        {
            replayPosition.Enqueue(transform.position);
        }    
        else
        {
            replayTimer += Time.deltaTime;
            if (replayPosition.Count == 0)
            {
                replay = false;
                Debug.Log(replayTimer);
            }
            else
            {
                transform.position = replayPosition.Dequeue();
            }
        }

    }
    
    
}
