using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceData : MonoBehaviour
{
    public GameObject nextSpace;
    public bool tax = false;
    public int amount = 3;
    public List<GameObject> colors = new List<GameObject>();
    
    
    void Start()
    {
        int i = Random.Range(0, 2);
        colors[i].gameObject.SetActive(false);
        if (i == 0)
        {
            tax = false;
        }
        else
        {
            tax = true;
        }
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character")
        {
            other.GetComponent<SpaceTraversal>().targetSpace = nextSpace;
            other.GetComponent<SpaceTraversal>().spacesLeft--;
            other.GetComponent<SpaceTraversal>().MoveToNextSpace();
        }
    }
}
