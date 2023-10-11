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

    [Header("Constantes")]
    public const int MAX_VALUE = 1000;
    public const int MIN_VALUE = -1000;

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
        //on map la valeur actuelle
        if(currentValue > MAX_VALUE){
            currentValue = MAX_VALUE;
        }else if(currentValue < MIN_VALUE){
            currentValue = MIN_VALUE;
        }
    }

    public void SubtractValue(int value){
        currentValue -= value;
        UpdateText();
        //on map la valeur actuelle
        if(currentValue > MAX_VALUE){
            currentValue = MAX_VALUE;
        }else if(currentValue < MIN_VALUE){
            currentValue = MIN_VALUE;
        }
    }

    public void MultiplyValue(int value){
        currentValue *= value;
        UpdateText();
        //on map la valeur actuelle
        if(currentValue > MAX_VALUE){
            currentValue = MAX_VALUE;
        }else if(currentValue < MIN_VALUE){
            currentValue = MIN_VALUE;
        }
    }

    public void DivideValue(int value){
        currentValue /= value;
        UpdateText();
        //on map la valeur actuelle
        if(currentValue > MAX_VALUE){
            currentValue = MAX_VALUE;
        }else if(currentValue < MIN_VALUE){
            currentValue = MIN_VALUE;
        }
    }

    public void LeftShiftValue(){
        currentValue *= 10;
        UpdateText();
        //on map la valeur actuelle
        if(currentValue > MAX_VALUE){
            currentValue = MAX_VALUE;
        }else if(currentValue < MIN_VALUE){
            currentValue = MIN_VALUE;
        }
    }

    public void RightShiftValue(){
        currentValue /= 10;
        UpdateText();
        //on map la valeur actuelle
        if(currentValue > MAX_VALUE){
            currentValue = MAX_VALUE;
        }else if(currentValue < MIN_VALUE){
            currentValue = MIN_VALUE;
        }
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
