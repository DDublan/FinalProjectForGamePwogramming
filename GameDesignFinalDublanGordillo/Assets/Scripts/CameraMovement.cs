using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject characterFocus = null;
    public bool gameReady = false;
    GameObject gameManager;
    public bool moveDown = false;
    public bool spin = false;
    void Start()
    {
        moveDown = true;
        gameManager = GameObject.Find("GameManager");
        while(moveDown)
        {
            transform.Translate(Vector3.left * 10 * Time.deltaTime);
        }
        Invoke("Spin", 4f);
    }

    void Update()
    {
        if (characterFocus != null)
        {
            transform.position = characterFocus.transform.position + new Vector3(0, 4, -7);
        }
    }

    void Spin()
    {
        spin = true;
        gameManager.GetComponent<GameManager>().Invoke("StartGame", 1f);
        while (spin)
        {
            transform.Rotate(new Vector3(100, 0, 0));
        }
    }
}
