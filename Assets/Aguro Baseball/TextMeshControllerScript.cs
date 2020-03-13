using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextMeshControllerScript : MonoBehaviour
{
    public TextMesh BallText;
    public TextMesh StrikeText;
    public TextMesh OutText;
    public int BallNumber;
    public int StrikeNumber;
    public int OutNumber;
    public bool IsNumberChanged;



    // Start is called before the first frame update
    void Start()
    {
        BallNumber = 0;
        StrikeNumber = 0;
        OutNumber = 0;
        IsNumberChanged = false;
    }

    // Update is called once per frame
    void Update()
    {
        BallNumber=Mathf.Max(BallNumber,0);
        StrikeNumber=Mathf.Max(StrikeNumber,0);
        OutNumber=Mathf.Max(OutNumber,0);
        if(BallNumber>=4)
        {
            BallNumber=0;
            StrikeNumber=0;
            IsNumberChanged=true;
        }
        if(StrikeNumber>=3)
        {
            BallNumber=0;
            StrikeNumber=0;
            OutNumber++;
            IsNumberChanged=true;
        }
        if(OutNumber>=3)
        {
            BallNumber=0;
            StrikeNumber=0;
            OutNumber=0;
            IsNumberChanged=true;
        }
        if(IsNumberChanged==true)
        {
            switch(BallNumber)
            {
                case 0:
                    BallText.text="B";
                    break;
                case 1:
                    BallText.text="B○";
                    break;
                case 2:
                    BallText.text="B○○";
                    break;
                case 3:
                    BallText.text="B○○○";
                    break;
                default:
                    BallText.text="B";
                    break;
            }
            switch(StrikeNumber)
            {
                case 0:
                    StrikeText.text="S";
                    break;
                case 1:
                    StrikeText.text="S○";
                    break;
                case 2:
                    StrikeText.text="S○○";
                    break;
                default:
                    StrikeText.text="S";
                    break;
            }
            switch(OutNumber)
            {
                case 0:
                    OutText.text="O";
                    break;
                case 1:
                    OutText.text="O○";
                    break;
                case 2:
                    OutText.text="O○○";
                    break;
                default:
                    OutText.text="O";
                    break;
            }
            IsNumberChanged=false;
        }
        // if(Input.GetKeyDown(KeyCode.Alpha1))
        // {
        //     BallNumberPlus();
        // }
        // if(Input.GetKeyDown(KeyCode.Alpha2))
        // {
        //     StrikeNumberPlus();
        // }
        // if(Input.GetKeyDown(KeyCode.Alpha3))
        // {
        //     OutNumberPlus();
        // }
        // if(Input.GetKeyDown(KeyCode.F1))
        // {
        //     BallNumberMinus();
        // }
        // if(Input.GetKeyDown(KeyCode.F2))
        // {
        //     StrikeNumberMinus();
        // }
        // if(Input.GetKeyDown(KeyCode.F3))
        // {
        //     OutNumberMinus();
        // }
        // if(Input.GetKeyDown(KeyCode.Escape))
        // {
        //     OutNumberPlus();
        // }

    }
    public void BallNumberPlus()
    {
        BallNumber++;
        IsNumberChanged=true;
    }
    public void StrikeNumberPlus()
    {
        StrikeNumber++;
        IsNumberChanged=true;
    }
    public void OutNumberPlus()
    {
        OutNumber++;
        IsNumberChanged=true;
    }
    public void BallNumberMinus()
    {
        BallNumber--;
        IsNumberChanged=true;
    }
    public void StrikeNumberMinus()
    {
        StrikeNumber--;
        IsNumberChanged=true;
    }
    public void OutNumberMinus()
    {
        OutNumber--;
        IsNumberChanged=true;
    }
    public void ResetNumber()
    {
        BallNumber=0;
        StrikeNumber=0;
        OutNumber=0;
        IsNumberChanged=true;
    }
    public void ResetScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
