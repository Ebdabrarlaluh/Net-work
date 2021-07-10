using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    [SerializeField]
    private GameObject pickUpText;
    private bool pickUpAllowed;

    private void Start()
    {
        pickUpText.gameObject.SetActive(false);
    }
    private void Update()
    {
        if(pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            PickObject();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    void PickObject()
    {
        Destroy(gameObject);
    }
   
}
