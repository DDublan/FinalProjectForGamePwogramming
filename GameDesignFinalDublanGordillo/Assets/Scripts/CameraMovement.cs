using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject characterFocus = null;
    public GameObject title;
    public bool gameReady = false;
    GameObject gameManager;
    public bool moveDown = false;
    public int moveDownSpeed = 10;
    public bool spin = false;
    void Start()
    {
        moveDown = true;
        gameManager = GameObject.Find("GameManager");
        Invoke("Spin", 4f);
    }

    void Update()
    {
        if (characterFocus != null)
        {
            transform.position = characterFocus.transform.position + new Vector3(0, 4, -7);
        }
        if (moveDown)
        {
            transform.Translate(Vector3.forward * moveDownSpeed * Time.deltaTime);
        }
        if (spin)
        {
            transform.Rotate(new Vector3(0, 0, 3600) * Time.deltaTime);
        }
    }

    void Spin()
    {
        title.SetActive(false);
        spin = true;
        moveDownSpeed *= 3;
        Invoke("GetSerious", 2f);
    }

    void GetSerious()
    {
        spin = false;
        moveDown = false;
        transform.eulerAngles = new Vector3 (10, 0, 0);
        gameManager.GetComponent<GameManager>().StartGame();
    }
}
