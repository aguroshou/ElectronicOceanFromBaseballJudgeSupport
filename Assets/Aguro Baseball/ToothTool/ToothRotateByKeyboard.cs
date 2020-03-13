using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToothRotateByKeyboard : MonoBehaviour
{
    public float rate;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightShift))
        {
            rate=0.00025f;
        }
        else if(Input.GetKey(KeyCode.LeftShift))
        {
            rate=0.1f;
        }
        else
        {
            rate=0.005f;
        }
        if(Input.GetKey(KeyCode.R))
        {
            transform.Rotate(new Vector3(30*rate,0,0));     
        }
        else if(Input.GetKey(KeyCode.F))
        {
            transform.Rotate(new Vector3(-30*rate,0,0));     
        }
        else if(Input.GetKey(KeyCode.T))
        {
            transform.Rotate(new Vector3(0,30*rate,0));     
        }
        else if(Input.GetKey(KeyCode.G))
        {
            transform.Rotate(new Vector3(0,-30*rate,0));     
        }
        else if(Input.GetKey(KeyCode.Y))
        {
            transform.Rotate(new Vector3(0,0,30*rate));     
        }
        else if(Input.GetKey(KeyCode.H))
        {
            transform.Rotate(new Vector3(0,0,-30*rate));     
        }
    }
}
