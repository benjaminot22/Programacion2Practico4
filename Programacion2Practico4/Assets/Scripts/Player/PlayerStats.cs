using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int startCoins = 0;
    private int currentHealth;
    public int currentcoins;

    void Start()
    {
        currentHealth = maxHealth;
        currentcoins = startCoins;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("¡Jugador atacado! Vida restante: " + currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("¡El jugador ha muerto!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            // gameObject.SetActive(false);
        }
       
    
}

    public void TakeCoins(int coins)
    {
        currentcoins += coins;
        Debug.Log("Monedas conseguidas: " + currentcoins);

    }
    public void SetHealth(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        Debug.Log("Vida actual: " + currentHealth); 

    }

    public void SetPoison(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0)
        {
            currentHealth = 0
                ;
        }
        Debug.Log("Vida actual: " + currentHealth);

    }
}