using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCoins : MonoBehaviour
{
    public int val;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            CoinCounter.instance.IncreaseCoins(val);
        }
    }
}
