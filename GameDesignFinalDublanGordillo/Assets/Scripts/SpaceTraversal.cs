using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTraversal : MonoBehaviour
{
    public GameObject targetSpace;
    public int spacesLeft = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (spacesLeft > -1)
        {
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
    }

    public void MoveToNextSpace()
    {
        transform.LookAt(targetSpace.transform.position);
        spacesLeft--;
    }
}
