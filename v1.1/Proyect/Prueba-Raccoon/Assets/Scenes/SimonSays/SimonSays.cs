using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SimonSays : MonoBehaviour
{
    [SerializeField] GameObject[] panel = new GameObject[6];
    [SerializeField] GameObject startGameButton;
    [SerializeField] GameObject errorPanel;

    private string[] colours = new string[6];

    [SerializeField] private bool stateOneCompleted = false;
    [SerializeField] private bool stateTwoCompleted = false;
    [SerializeField] private bool stateThreeCompleted = false;

    private string[] dessiredColours = new string[6];
    private string dessiredNextColour;

    private void Start()
    {
        colours[0] = "Amarillo";
        colours[1] = "Rojo";
        colours[2] = "Verde";
        colours[3] = "Rosa";
        colours[4] = "Azul";
        colours[5] = "Naranja";
    }

    public void BotonUtilizado(int a)
    {
        if (dessiredNextColour == null)
        {
            for (int i = 0; i < panel.Length; i++)
            {
                panel[i].SetActive(false);
            }
            errorPanel.SetActive(true);
            StopAllCoroutines();
            StartCoroutine(GameWithDelay());
        }
        else
        {
            if (dessiredNextColour == colours[a])
            {
                SetNextDessiredColour();
            }
            else
            {
                errorPanel.SetActive(true);
                StopAllCoroutines();
                StartCoroutine(GameWithDelay());
            }
        }
        
    }
    int z = 0;
    public void StartGame()
    {
        startGameButton.SetActive(false);
        StartCoroutine(GameWithDelay());
    }

    private IEnumerator GameWithDelay()
    {
        yield return new WaitForSeconds(1);
        errorPanel.SetActive(false);
        yield return new WaitForSeconds(1);
        z = 0;
        int maxNumbers = 0;
        if (!stateOneCompleted)
        {
            maxNumbers = 3;
        }
        else if (stateOneCompleted && !stateTwoCompleted)
        {
            maxNumbers = 4;
        }
        else if (stateOneCompleted && stateTwoCompleted && !stateThreeCompleted)
        {
            maxNumbers = 5;
        }

        for (int i = 0; i < maxNumbers; i++)
        {
            yield return new WaitForSeconds(1);
            int random = Random.Range(0, 6);
            panel[random].SetActive(true);
            dessiredColours[i] = panel[random].tag;
            yield return new WaitForSeconds(2);
            panel[random].SetActive(false);
        }

        SetNextDessiredColour();
    }

    private void SetNextDessiredColour()
    {
        if (!stateOneCompleted)
        {
            if (z == 3)
            {
                stateOneCompleted = true;
                StartCoroutine(GameWithDelay());
            }
        }
        else if (stateOneCompleted && !stateTwoCompleted)
        {
            if (z == 4)
            {
                stateTwoCompleted = true;
                StartCoroutine(GameWithDelay());
            }
        }
        else if (stateOneCompleted && stateTwoCompleted && !stateThreeCompleted)
        {
            if (z == 5)
            {
                int rand = Random.Range(1, 4);

                while (rand == SceneManager.GetActiveScene().buildIndex)
                {
                    rand = Random.Range(1, 4);
                }
                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().simonSays = true;
                SceneManager.LoadScene(rand);
            }
        }
        dessiredNextColour = dessiredColours[z];
        z++;
    }

}
