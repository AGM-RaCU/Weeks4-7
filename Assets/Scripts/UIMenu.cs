using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{

    public TMP_Dropdown dropdown;
    public SpriteRenderer CoinSprite;
    public GameObject CoinsPrefab;

    private void Start()
    {
        CoinSprite.sprite = dropdown.options[0].image;
    }

    public void OnValueChanged(int index)
    {
        CoinSprite.sprite = dropdown.options[index].image;
    }

    public void spawn()
    {
        GameObject newCoin = Instantiate(CoinsPrefab);
        newCoin.GetComponent<Coin>().CSpriteRenderer.sprite = CoinSprite.sprite;
    }
}
