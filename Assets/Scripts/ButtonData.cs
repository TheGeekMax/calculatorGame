using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ButtonData : MonoBehaviour{
    public TextMeshProUGUI buttonText;
    public Operation operation;
    public int value;
    
    void Start(){
        SetText(operation);
    }

    public void SetText(Operation op){
        switch(op){
            case Operation.None:
                buttonText.text = "__";
                break;
            case Operation.Addition:
                buttonText.text = "+" + value.ToString();
                break;
            case Operation.Subtraction:
                buttonText.text = "-" + value.ToString();
                break;
            case Operation.Multiplication:
                buttonText.text = "x" + value.ToString();
                break;
            case Operation.Division:
                buttonText.text = "/" + value.ToString();
                break;
            case Operation.LeftShift:
                buttonText.text = "<<";
                break;
            case Operation.RightShift:
                buttonText.text = ">>";
                break;
        }
    }

    public void SetOperation(Operation op){
        operation = op;
    }

    public void OnClick(){
        GameManager.instance.DoOperation(operation, value);
    }
}
