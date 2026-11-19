using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    // Se activa inmediatamente cuando algo entra en el área del trigger
    void OnTriggerEnter2D(Collider2D col)
    {
        // Si el objeto que toca la zona tiene la etiqueta "Player"
        if (col.CompareTag("Player"))
        {
            // Reinicia la escena actual de forma instantánea [RECOMENDACIÓN: Que llame a una función den Game manager]
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            // Si es cualquier otro objeto (enemigos, proyectiles, etc.), lo elimina
            Destroy(col.gameObject);
        }
    }
}
