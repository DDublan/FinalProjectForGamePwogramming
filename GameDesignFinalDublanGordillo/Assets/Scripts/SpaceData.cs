using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceData : MonoBehaviour
{
    public GameObject nextSpace;
    SpaceTraversal spaceTraversal;
    void Start()
    {
        
    }

    // i have to put this here to push origin screw you github
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character")
        {
            other.GetComponent<SpaceTraversal>().targetSpace = nextSpace;
            other.GetComponent<SpaceTraversal>().MoveToNextSpace();
        }
    }
}
