using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropDownLogic : MonoBehaviour
{

    public TMP_Dropdown dropdown;
    public SpriteRenderer CoinSprite;

    private void Start()
    {
        CoinSprite.sprite = dropdown.options[0].image;
    }

    public void OnValueChanged(int index)
    {
        CoinSprite.sprite = dropdown.options[index].image;
    }

}
