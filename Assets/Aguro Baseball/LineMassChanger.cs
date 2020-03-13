using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMassChanger : MonoBehaviour
{
    public float rate;
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
            rate=1.001f;
            moveSpeed=0.00005f;
        }
        else if(Input.GetKey(KeyCode.LeftShift))
        {
            rate=1.4f;
            moveSpeed=0.02f;
        }
        else
        {
            rate=1.02f;
            moveSpeed=0.001f;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale=new Vector3(transform.localScale.x*rate,transform.localScale.y*rate,transform.localScale.z);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale=new Vector3(transform.localScale.x/rate,transform.localScale.y/rate,transform.localScale.z);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 pos = transform.position;
            transform.position = new Vector3(pos.x, pos.y + moveSpeed, pos.z);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 pos = transform.position;
            transform.position = new Vector3(pos.x, pos.y - moveSpeed, pos.z);
        }

    }
}
