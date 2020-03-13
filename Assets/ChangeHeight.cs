using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHeight : MonoBehaviour
{
    public GameObject TopObject;
    public GameObject BottomObject;
    public float midY;
    public float diffY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        diffY=TopObject.transform.position.y-BottomObject.transform.position.y;
        midY=diffY/2+BottomObject.transform.position.y;
        transform.position=new Vector3(transform.position.x,midY,transform.position.z);
        transform.localScale=new Vector3(transform.localScale.x,diffY,transform.localScale.z);
    }
}
