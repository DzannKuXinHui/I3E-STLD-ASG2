using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject RetryButton;
    public GameObject QuitButton;
    public GameObject DeathScreen;
    public GameObject Game;
    public int maxHealth = 100;
    private int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Player took damage: " + damage + ". Current health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Handle player death (e.g., respawn, game over screen, etc.)
        Debug.Log("Player died!");
        DeathScreen.SetActive(true);
        StartCoroutine(ShowButtons(3f));
        Game.SetActive(false);
    }

    private IEnumerator ShowButtons(float delay)
    {
        yield return new WaitForSeconds(delay);

        RetryButton.SetActive(true);
        QuitButton.SetActive(true);
    }
}
