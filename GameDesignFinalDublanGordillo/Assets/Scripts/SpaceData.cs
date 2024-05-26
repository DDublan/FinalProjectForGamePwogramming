using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceData : MonoBehaviour
{
    public GameObject nextSpace;
    
    
    void Start()
    {
        
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
