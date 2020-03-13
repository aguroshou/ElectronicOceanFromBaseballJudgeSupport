using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByKeyboard : MonoBehaviour
{
    public GameObject Camera;
    public float rate;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightShift))
        {
            rate = 0.00025f;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            rate = 0.1f;
        }
        else
        {
            rate = 0.005f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position -= new Vector3(Camera.transform.right.x * rate, 0, Camera.transform.right.z * rate);
            transform.position -= new Vector3(Camera.transform.right.x * rate, 0, Camera.transform.right.z * rate);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Camera.transform.right.x * rate, 0, Camera.transform.right.z * rate);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(Camera.transform.forward.x * rate, 0, Camera.transform.forward.z * rate);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(Camera.transform.forward.x * rate, 0, Camera.transform.forward.z * rate);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 30 * rate, 0));
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, -30 * rate, 0));
        }

    }
}
