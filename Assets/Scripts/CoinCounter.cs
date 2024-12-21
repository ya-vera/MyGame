using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;
    public Text coinText;
    public int curCoins = 0;

    public GameObject endGamePanel;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        coinText.text = "PIGS: " + curCoins.ToString();
        endGamePanel.SetActive(false);
    }

    void Update()
    {
        
    }

    public void IncreaseCoins(int x)
    {
        curCoins += x;
        coinText.text = "PIGS: " + curCoins.ToString();

        if (curCoins == 6)
        {
            EndGame();
        }

    }

    private void EndGame()
    {
        Debug.Log("Game over");
        endGamePanel.SetActive(true);

    }

}
