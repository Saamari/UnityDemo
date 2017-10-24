using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coinpickup : MonoBehaviour
{
    public Text countText;



    private int count;

    void Start()
    {
        count = 0;
        SetCountText();

    }




    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("Trigger"); // testing if the trigger works 
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Coins: " + count.ToString();

    }
}
