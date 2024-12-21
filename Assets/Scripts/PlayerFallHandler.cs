using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFallHandler : MonoBehaviour
{
    
    private float resetHeight1 = -5.69f;
    private float resetHeight2 = 4.5f;

    private float resetWidth1 = -8.379f;
    private float resetWidth2 = 8.41f;

    void Update()
    {
        if (transform.position.y < resetHeight1 || transform.position.y > resetHeight2 || transform.position.x < resetWidth1 || transform.position.x > resetWidth2)
        {
            Debug.Log("Restart");
            ResetGame();
        }
    }

    void ResetGame()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}