using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public SpriteRenderer CSpriteRenderer;
    public float DespawnCount;
    public float DespawnLimit;

    // Start is called before the first frame update
    void Start()
    {
        DespawnLimit = Random.Range(1, 10);
        Vector2 Position = transform.position;
        Position.x = Random.Range(-10, 10);
        transform.position = Position;
    }

    // Update is called once per frame
    void Update()
    {
        DespawnCount += Time.deltaTime;
        Debug.Log(DespawnCount);
        if(DespawnCount >= DespawnLimit)
        {
            Destroy(gameObject);
        }
       
    }
}
