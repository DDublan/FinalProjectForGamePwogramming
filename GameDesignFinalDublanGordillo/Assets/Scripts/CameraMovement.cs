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
    int slidesLeft = 9;
    void Start()
    {
        LetsAGo();
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

    void LetsAGo()
    {
        title.SetActive(true);
        transform.position = new Vector3(-6, 100, 5);
        transform.eulerAngles = new Vector3(90, 0, 0);
        moveDown = true;
        gameManager = GameObject.Find("GameManager");
        Invoke("Spin", 4f);
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

    public void NewsReport()
    {
        characterFocus = null;
        transform.position = new Vector3(0f, -10f, 85.2f);
        transform.eulerAngles = Vector3.zero;
        Invoke("NextSlide", 3f);
    }

    public void NextSlide()
    {
        if (slidesLeft > 0)
        {
            slidesLeft--;
            transform.Translate(0, 0, 10);
            Invoke("NextSlide", 3f);
        }
        else
        {
            Invoke("LetsAGo", 5f);
        }
    }
}
