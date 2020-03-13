using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLineColor : MonoBehaviour
{
    public Material LineColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColorWhite()
    {
        LineColor.color=Color.white;
    }
    public void ChangeColorRed()
    {
        LineColor.color=Color.red;
    }
    public void ChangeColorGreen()
    {
        LineColor.color=Color.green;
    }
    public void ChangeColorBlue()
    {
        LineColor.color=Color.blue;
    }
    public void ChangeColorCyan()
    {
        LineColor.color=Color.cyan;
    }
    public void ChangeColorMagenta()
    {
        LineColor.color=Color.magenta;
    }
    public void ChangeColorYellow()
    {
        LineColor.color=Color.yellow;
    }
}
