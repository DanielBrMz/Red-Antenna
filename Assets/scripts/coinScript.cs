using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coinScript : MonoBehaviour
{

    public NewBehaviourScript playerController;
    public TMP_Text coinText;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<NewBehaviourScript>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // If the player collides with the coin, destroy the coin
        if (collision.gameObject.tag == "Player")
        {
            playerController.coins++;
            coinText.text = "Coins: " + playerController.coins.ToString();
            Destroy(gameObject);
        }
    }
}