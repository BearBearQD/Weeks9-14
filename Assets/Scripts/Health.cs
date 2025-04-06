using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    // Public variables
    public float maxHealth = 100f;                // Maximum health value
    public float currentHealth;                   // Current health value
    public TextMeshProUGUI healthText;            // Reference to the TextMeshProUGUI UI element

    void Start()
    {
        // Initialize current health to max health at the start
        currentHealth = maxHealth;
    }

    private void Update()
    {
         Debug.Log(currentHealth);
         if (healthText != null)
         {
             healthText.text = "Health: " + currentHealth;
         }
         else
         {
             Debug.LogError("Health TextMeshProUGUI is not assigned!");
         }

    }

    // Method to increase health
    public void IncreaseHealth(float amount)
    {
        currentHealth += amount;
        Debug.Log("health");
    }

    // Method to decrease health
    public void DecreaseHealth(float amount)
    {
        currentHealth -= amount;
    }


}
