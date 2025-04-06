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
        UpdateHealthText(); // Update UI when the game starts
    }

    // Method to increase health
    public void IncreaseHealth(float amount)
    {
        currentHealth += amount;

        // Clamp health to max health (health cannot go above maxHealth)
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        UpdateHealthText();  // Update health UI after increasing health
    }

    // Method to decrease health
    public void DecreaseHealth(float amount)
    {
        currentHealth -= amount;

        // Clamp health to ensure it doesn't go below zero
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        UpdateHealthText();  // Update health UI after decreasing health
    }

    // Method to update the health text UI
    private void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth.ToString("F0");  // Display health as an integer (F0 = no decimals)
        }
        else
        {
            Debug.LogError("Health TextMeshProUGUI is not assigned!");
        }
    }
}
