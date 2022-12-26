using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            int rand = Random.Range(1, 4);
            
            while (rand == SceneManager.GetActiveScene().buildIndex)
            {
                rand = Random.Range(1, 4);
            }
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().mazeCheck = true;
            SceneManager.LoadScene(rand);
        }
    }
}
