using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] paddles;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            paddles[0].transform.position += Vector3.up/10;
        }else if(Input.GetKey(KeyCode.S))
        {
            paddles[0].transform.position += Vector3.down/10;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            paddles[1].transform.position += Vector3.up/10;
        }else if(Input.GetKey(KeyCode.DownArrow))
        {
            paddles[1].transform.position += Vector3.down/10;
        }
    }
}
