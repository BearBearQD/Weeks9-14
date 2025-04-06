using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Properties of the item
    public string itemName;            // Name of the item
    public GameObject itemPrefab;  // The prefab to instantiate in the scene
    public int healthIncreaseAmount = 20;  // Amount to increase health when used
    Health playerHealth;
    GameObject player;

    private void Start()
    {
        // Find the player GameObject by its tag
        player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            // Find the Health component on the player
            playerHealth = player.GetComponent<Health>();
            Debug.Log("nadgna");
            if (playerHealth == null)
            {
                Debug.LogError("Health script not found on player!");
            }
        }
        else
        {
            Debug.LogError("Player GameObject not found! Make sure the player is tagged as 'Player'.");
        }

    }
    public void InitializeItem(string name, GameObject prefab)
    {
        itemName = name;
        itemPrefab = prefab;
    }

    public virtual void Use()
    {
        Debug.Log("Item used: " + itemName);

        // Check if the player's Health script is assigned
        if (playerHealth != null)
        {
            playerHealth.currentHealth += healthIncreaseAmount;
            Debug.Log("Health increased by " + healthIncreaseAmount);
        }
        else
        {
            Debug.LogError("Player health reference is missing!");
        }
    }
}
