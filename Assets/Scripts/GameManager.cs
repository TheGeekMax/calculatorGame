using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour{
    int goalValue = 100;

    int currentValue = 0;

    [Header("UI Elements")]
    public TextMeshProUGUI goalText;
    public TextMeshProUGUI currentText;

    [Header("Data")]
    public static GameManager instance;

    void Start(){

        if(instance == null){
            instance = this;
        }else{
            Destroy(this);
        }
        UpdateText();
    }

    void Update(){
        if(currentValue == goalValue){
            Debug.Log("You win!");
        }    
    }

    void UpdateText(){
        goalText.text = "goal :" + goalValue.ToString();
        currentText.text = "current:" + currentValue.ToString();
    }

    public void AddValue(int value){
        currentValue += value;
        UpdateText();
    }

    public void SubtractValue(int value){
        currentValue -= value;
        UpdateText();
    }

    public void MultiplyValue(int value){
        currentValue *= value;
        UpdateText();
    }

    public void DivideValue(int value){
        currentValue /= value;
        UpdateText();
    }

    public void LeftShiftValue(){
        currentValue *= 10;
        UpdateText();
    }

    public void RightShiftValue(){
        currentValue /= 10;
        UpdateText();
    }

    public void DoOperation(Operation op, int value){
        switch(op){
            case Operation.Addition:
                AddValue(value);
                break;
            case Operation.Subtraction:
                SubtractValue(value);
                break;
            case Operation.Multiplication:
                MultiplyValue(value);
                break;
            case Operation.Division:
                DivideValue(value);
                break;
            case Operation.LeftShift:
                LeftShiftValue();
                break;
            case Operation.RightShift:
                RightShiftValue();
                break;
        }
    }
}
