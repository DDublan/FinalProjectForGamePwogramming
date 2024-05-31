using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SplitPath : MonoBehaviour
{
    public GameObject firstPath;
    public GameObject secondPath;
    public GameObject inputText;
    GameObject gameManager;
    bool choose = true;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Character" && choose)
        {
            other.GetComponent<SpaceTraversal>().choosePath = true;
            if (gameManager.GetComponent<GameManager>().botTurn)
            {
                int i = Random.Range(0, 2);
                if (i == 0)
                {
                    ChoosePath(other, firstPath);
                }
                else
                {
                    ChoosePath(other, secondPath);
                }
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                ChoosePath(other, firstPath);
            }
            else if (Input.GetKey(KeyCode.E))
            {
                ChoosePath(other, secondPath);
            }
        }
    }

    void ChoosePath(Collider player, GameObject path)
    {
        player.GetComponent<SpaceTraversal>().choosePath = false;
        player.GetComponent<SpaceTraversal>().targetSpace = path;
        player.GetComponent<SpaceTraversal>().MoveToNextSpace();
        choose = false;
        inputText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character")
        {
            choose = true;
            inputText.gameObject.SetActive(true);
        }
    }
}
