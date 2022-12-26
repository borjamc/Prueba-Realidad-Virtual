using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SafeBox : MonoBehaviour
{
    public bool[] dialsCorrect = new bool[3];
    private int dialsCorrectIndex = 0;

    public void AddCorrectDial()
    {
        dialsCorrectIndex = 0;
        for (int i = 0; i < dialsCorrect.Length; i++)
        {
            if (dialsCorrect[i] == true)
            {
                dialsCorrectIndex++;
            }
        }
        if (dialsCorrectIndex == 3)
        {
            int rand = Random.Range(1, 4);

            while (rand == SceneManager.GetActiveScene().buildIndex)
            {
                rand = Random.Range(1, 4);
            }
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().scapeRoom = true;
            SceneManager.LoadScene(rand);
        }
    }

}
