using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> players = new List<GameObject>();
    public GameObject cameraFocus;
    public bool botTurn;
    int currentTurn = 0;
    void Start()
    {
       
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        players[currentTurn].gameObject.GetComponent<SpaceTraversal>().StartTurn();
        cameraFocus.GetComponent<CameraMovement>().characterFocus = players[currentTurn].gameObject;
    }

    public void NextTurn()
    {
        if (currentTurn < 3)
        {
            currentTurn++;
            players[currentTurn].gameObject.GetComponent<SpaceTraversal>().StartTurn();
            cameraFocus.GetComponent<CameraMovement>().characterFocus = players[currentTurn].gameObject;
        }
        else
        {
            currentTurn = 0;
            cameraFocus.GetComponent<CameraMovement>().NewsReport();
        }
    }
}
