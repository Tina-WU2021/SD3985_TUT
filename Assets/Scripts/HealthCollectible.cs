using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        RubyController player = collision.GetComponent<RubyController>();

        //if (controller != null)
        if (collision.tag == "Player")
        {
            if (player.health < player.maxHealth)
            {
                player.ChangeHealth(1);
                Destroy(gameObject);
                Debug.Log("current health" + player.health);
            }
        }
    }
}