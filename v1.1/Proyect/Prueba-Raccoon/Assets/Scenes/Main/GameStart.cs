using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

    public void StartGame()
    {
        int rand = Random.Range(1, 3);

        while (rand == SceneManager.GetActiveScene().buildIndex)
        {
            rand = Random.Range(1, 3);
        }
        SceneManager.LoadScene(rand);
    }
}
