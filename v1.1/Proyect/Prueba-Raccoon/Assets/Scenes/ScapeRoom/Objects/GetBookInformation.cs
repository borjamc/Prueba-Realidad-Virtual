using System.Collections;
using System.Collections.Generic;
using Unity.XRContent.Interaction;
using UnityEngine;

public class GetBookInformation : MonoBehaviour
{
    [SerializeField] bool reset = false;
    private enum Colours
    {
        Amarillo,
        Rojo,
        Azul
    }
    [SerializeField] Colours colour = Colours.Amarillo;
    private HingeJoint hinge;
    private BookPuzzle bookPuzzle;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        bookPuzzle = GetComponentInParent<BookPuzzle>();
    }
    public void ButtonPressed()
    {
        bookPuzzle.AddColour(colour.ToString());
    }
}
