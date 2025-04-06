using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    // Public variables
    public int maxHealth = 100;                // Maximum health value
    public int currentHealth;                   // Current health value
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
    public void IncreaseHealth(int amount)
    {
        currentHealth += amount;
        Debug.Log("health");
    }

}
