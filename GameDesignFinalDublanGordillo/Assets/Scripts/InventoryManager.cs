using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject character;
    public int money;
    int stars;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = character.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Special")
        {
            int price = other.gameObject.GetComponent<SpecialEncounter>().starPrice;
            if (money >= price)
            {
                money -= price;
                stars++;
            }
        }
    }
}
