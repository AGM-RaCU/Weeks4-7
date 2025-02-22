using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public SpriteRenderer CSpriteRenderer;//sprite renderer
    public float DespawnCount;//timer to despawn prefab
    public float DespawnLimit;//time limit to despawn prefab

    void Start()
    {
        DespawnLimit = Random.Range(1, 10);//randomizer for time limit
        Vector2 Position = transform.position;//position variable to change prefab spawn location
        Position.x = Random.Range(-10, 10);//x position randomizer
        transform.position = Position;//position transform
    }

    void Update()
    {
        DespawnCount += Time.deltaTime;//increase timer as time passes
        Debug.Log(DespawnCount);//check timer on console
        if(DespawnCount >= DespawnLimit)//check if timer reached time limit
        {
            Destroy(gameObject);//destroy prefab when time limit is reached
        }
       
    }
}
