using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPuzzle : MonoBehaviour
{
    private string colour1 = "";
    private string colour2 = "";
    private string colour3 = "";

    [SerializeField] GameObject frame;

    public void AddColour(string colour = "")
    {
        if (colour1 == "")
        {
            if (colour != "Amarillo")
            {
                colour = "";
            }
            else
            {
                colour1 = colour;
            }
            
        }
        else if (colour2 == "")
        {
            if (colour != "Azul")
            {
                colour1 = "";
            }
            else
            {
                colour2 = colour;
            }
            
        }
        else if (colour3 == "")
        {
            if (colour != "Rojo")
            {
                colour1 = "";
                colour2 = "";
            }
            else
            {
                colour3 = colour;
            }
            
        }

        if (colour1 == "Amarillo" && colour2 == "Azul" && colour3 == "Rojo")
        {
            frame.SetActive(false);
        }
    }

}
