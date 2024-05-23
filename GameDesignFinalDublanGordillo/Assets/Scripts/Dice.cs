using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    bool rolling = true;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (rolling)
        {
            transform.Rotate(new Vector3(-666, 420, 69) * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rolling = false;
        }
    }
}
