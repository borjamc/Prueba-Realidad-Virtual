using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.XRContent.Interaction;
using UnityEngine;

public class BoxDial : MonoBehaviour
{

    public int numberCorrect;
    private int actualNumberSeleccted;
    [SerializeField] TextMeshProUGUI numberText;
    [SerializeField] float knobNumber;
    private SafeBox safeBox;

    private void Start()
    {
        safeBox = gameObject.GetComponentInParent<SafeBox>();
    }

    public void OnNumberChange()
    {
        knobNumber = this.gameObject.GetComponent<XRKnob>().Value * 10;
        actualNumberSeleccted = (int)knobNumber;
        numberText.text = actualNumberSeleccted.ToString();
        if (actualNumberSeleccted == numberCorrect)
        {
            if (numberCorrect == 0)
            {
                safeBox.dialsCorrect[0] = true;
            }
            else if (numberCorrect == 2)
            {
                safeBox.dialsCorrect[1] = true;
            }
            else if (numberCorrect == 6)
            {
                safeBox.dialsCorrect[2] = true;
            }
            safeBox.AddCorrectDial();
        }
        else
        {
            if (numberCorrect == 0)
            {
                safeBox.dialsCorrect[0] = false;
            }
            else if (numberCorrect == 2)
            {
                safeBox.dialsCorrect[1] = false;
            }
            else if (numberCorrect == 6)
            {
                safeBox.dialsCorrect[2] = false;
            }
            safeBox.AddCorrectDial();
        }
        
    }

}
