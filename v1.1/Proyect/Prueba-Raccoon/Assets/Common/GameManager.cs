using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool activateTimer = false;
    [SerializeField] GameObject textObjectContainer;
    public bool mazeCheck = false;
    public bool simonSays = false;
    public bool scapeRoom = false;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
        mazeCheck = false;
        simonSays = false;
        scapeRoom = false;
    }

    public float targetTime = 300.0f;

    void Update()
    {
        if (activateTimer)
        {
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }
    }

    void timerEnded()
    {
        targetTime = 300;
        int rand = Random.Range(1, 4);

        while (rand == SceneManager.GetActiveScene().buildIndex)
        {
            rand = Random.Range(1, 4);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Laberinto"))
        {
            mazeCheck = false;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("ScapeRoom"))
        {
            scapeRoom = false;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("SimonSays"))
        {
            simonSays = false;
        }
        SceneManager.LoadScene(rand);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene != SceneManager.GetSceneByName("Main"))
        {
            activateTimer = true;
        }
        textObjectContainer = GameObject.FindGameObjectWithTag("Objectives");
        if (scene == SceneManager.GetSceneByName("Laberinto"))
        {
            textObjectContainer.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Encuentra el mecanismo para escapar del laberinto";
        }
        else if (scene == SceneManager.GetSceneByName("ScapeRoom"))
        {
            textObjectContainer.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Encuentra los 3 numeros para abrir la caja fuerte";
        }
        else if (scene == SceneManager.GetSceneByName("SimonSays"))
        {
            textObjectContainer.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Supera 3 rondas de Simon Dice";
        }
        Historial();
    }

    void Historial()
    {
        if (textObjectContainer != null)
        {
            textObjectContainer.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = mazeCheck ? "Superado" : "No superado";
            textObjectContainer.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = simonSays ? "Superado" : "No superado";
            textObjectContainer.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = scapeRoom ? "Superado" : "No superado";
        }
        
    }

}
