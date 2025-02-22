using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{

    public TMP_Dropdown dropdown;//dropdown
    public SpriteRenderer CoinSprite;//sprite renderer for coin sprite
    public GameObject CoinsPrefab;//coin prefab
    public float TossForce = 0.0f;// how hard coin will be tossed
    public Slider slider;//toss force slider

    private void Start()
    {
        CoinSprite.sprite = dropdown.options[0].image;//start on loonie
       
    }

    public void OnSliderValueChanged(float TossForce)
    {
        Debug.Log(TossForce);//check for toss force on console

        Vector2 Position = CoinsPrefab.transform.position;//position variable to change prefab spawn position

        if (TossForce == 0.0f)//check toss force for 0 force
        {
            Position.y = 1;//spawn near bottom of the screen
        }
        if (TossForce == 1.0f)//check toss force for 1 force
        {
            Position.y = 3;//spawn near middle of the screen
        }
        if (TossForce == 2.0f)//check toss force for 2 force
        { 
            Position.y = 5;//spawn near top of the screen
        }

    }

    public void OnValueChanged(int index)
    {
        CoinSprite.sprite = dropdown.options[index].image;//change sprite in dropdown
    }

    public void spawn()
    {
        GameObject newCoin = Instantiate(CoinsPrefab);//get coin prefab
        newCoin.GetComponent<Coin>().CSpriteRenderer.sprite = CoinSprite.sprite;//apply coin sprite to prefab
    }
}
