using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject CoinsPrefab;
    Coin coin;
    // Start is called before the first frame update
    public void spawn()
    {
        Instantiate(CoinsPrefab);
        coin = GetComponent<Coin>;
        Coin.sprite = 
    }

}
