using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public GameObject character;
    bool rolling = true;
    int roll = 1;
    public List<Vector3> rollValues = new List<Vector3>();
    
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rolling)
            {
                rolling = false;
                roll = Random.Range(1, 6);
                transform.eulerAngles = rollValues[roll-1];
                character.GetComponent<SpaceTraversal>().spacesLeft = roll-1;
            }
            else
            {
                rolling = true;
            }
        }
    }
}
