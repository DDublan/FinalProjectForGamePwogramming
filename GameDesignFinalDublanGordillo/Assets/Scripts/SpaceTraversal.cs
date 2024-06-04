using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceTraversal : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject dice;
    public GameObject targetSpace;
    public TextMeshProUGUI spaceCountdown;
    public int spacesLeft = 0; // probably will help with task one, when the value gets to -1 make sure to hide the ui text
    public bool choosePath = false;
    public bool myTurn = false;
    
    void Start()
    {
        spaceCountdown.gameObject.SetActive(false);
    }

    
    void Update()
    {
        if (spacesLeft > -1 && !choosePath && !dice.gameObject.activeSelf)
        {
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
            spaceCountdown.gameObject.SetActive(true);
            spaceCountdown.text = (spacesLeft + 1).ToString();
        }
        if (spacesLeft < 0 && !dice.gameObject.activeSelf && myTurn)
        {
            gameManager.GetComponent<GameManager>().Invoke("NextTurn", 1f);
            myTurn = false;
            spaceCountdown.gameObject.SetActive(false);
        }
    }

    public void MoveToNextSpace()
    {
        transform.LookAt(targetSpace.transform.position);
    }

    public void StartTurn()
    {
        myTurn = true;
        spacesLeft = 1;
        dice.SetActive(true);
        dice.GetComponent<Dice>().rolling = true;
    }
}
