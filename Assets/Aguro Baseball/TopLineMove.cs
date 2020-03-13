using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopLineMove : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightShift))
        {
            moveSpeed=0.00005f;
        }
        else if(Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed=0.02f;
        }
        else
        {
            moveSpeed=0.001f;
        }
        if(Input.GetKey(KeyCode.T))
        {
            Vector3 pos = transform.position;
            transform.position = new Vector3(pos.x, pos.y + moveSpeed, pos.z);
        }
        else if(Input.GetKey(KeyCode.G))
        {
            Vector3 pos = transform.position;
            transform.position = new Vector3(pos.x, pos.y - moveSpeed, pos.z);
        }
    }
}
