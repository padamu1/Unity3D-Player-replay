using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class PlayerMovementInput : MonoBehaviour
{
    new Transform transform;
    private Queue<StringBuilder> replayKeyCodes;
    private string replayKey;
    private StringBuilder inputKey;
    private bool replay;
    private float timer;
    private float replayTimer;
    void Awake()
    {
        replayKeyCodes = new Queue<StringBuilder>();
        replay = false;
        timer = 0f;
        replayTimer = 0f;
    }
    void Start()
    {
        transform = this.GetComponent<Transform>();
    }

    void Update()
    {
        if (!replay)
        {
            inputKey = new StringBuilder();
            timer += Time.deltaTime;
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, 1) * Time.deltaTime;
                inputKey.Append("W");
            }
            if (Input.GetKey(KeyCode.S) )
            {
                transform.position += new Vector3(0, 0, -1) * Time.deltaTime;
                inputKey.Append("S");
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-1, 0, 0) * Time.deltaTime;
                inputKey.Append("A");
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
                inputKey.Append("D");
            }
            inputKey.Append("-");
            if (Input.GetKey(KeyCode.R))
            {
                replay = true;
                transform.position = new Vector3(0f, 0.5f, 0f);
                Debug.Log(timer);
            }
            replayKeyCodes.Enqueue(inputKey);
        }
        else
        {
            replayTimer += Time.deltaTime;
            if (replayKeyCodes.Count == 0)
            {
                replay = false;
                Debug.Log(replayTimer);
            }
            else
            {
                replayKey = replayKeyCodes.Dequeue().ToString();
                if (replayKey.Contains("W"))
                {
                    transform.position += new Vector3(0, 0, 1) * Time.deltaTime;
                }
                if (replayKey.Contains("S"))
                {
                    transform.position += new Vector3(0, 0, -1) * Time.deltaTime;
                }
                if (replayKey.Contains("A"))
                {
                    transform.position += new Vector3(-1, 0, 0) * Time.deltaTime;
                }
                if (replayKey.Contains("D"))
                {
                    transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
                }
            }
            
        }
        
    } 
}
