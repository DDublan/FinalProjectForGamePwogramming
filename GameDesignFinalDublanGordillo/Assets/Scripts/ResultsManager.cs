using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultsManager : MonoBehaviour
{
    public TextMeshProUGUI results;
    int i;
    public string mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        i = Random.Range(0, 4);
        results.text = "Player " + (i + 1) + " won";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
