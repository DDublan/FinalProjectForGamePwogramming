using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public GameObject character;
    public List<Vector3> rollValues = new List<Vector3>();
    public bool rolling = true;
    int roll = 1;
    public bool botRoll = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (rolling)
        {
            transform.Rotate(new Vector3(-6666, 4200, 690) * Time.deltaTime);
        }
        transform.position = character.transform.position+new Vector3(0, 2, 0);

        if (Input.GetKeyDown(KeyCode.Space) && !botRoll)
        {
            if (rolling)
            {
                rolling = false;
                roll = Random.Range(1, 7);
                transform.eulerAngles = rollValues[roll - 1];
                Invoke("RollDice", 1f);
            }
        }
    }

    public void RollDice()
    {
        character.GetComponent<SpaceTraversal>().spacesLeft = roll - 1;
        character.GetComponent<SpaceTraversal>().MoveToNextSpace();
        gameObject.SetActive(false);
    }
}
