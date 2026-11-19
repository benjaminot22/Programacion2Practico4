using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta1Script : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}