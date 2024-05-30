using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
    }
}
