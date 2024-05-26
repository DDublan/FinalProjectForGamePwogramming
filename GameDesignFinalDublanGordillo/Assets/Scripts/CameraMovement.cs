using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject characterFocus;
    void Start()
    {
        
    }

    void Update()
    {
        if (characterFocus != null)
        {
            transform.position = characterFocus.transform.position + new Vector3(0, 4, -7);
        }
    }
}
