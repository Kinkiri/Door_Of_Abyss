using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFactory : MonoBehaviour
{
    [SerializeField] GameObject cardPrefab;
    [SerializeField] Transform handContainer;

    public GameObject CreateCard(Card data)
    {
        GameObject cardObj = Instantiate(cardPrefab, handContainer);
        cardObj.GetComponent<CardView>().UpdateVisuals(data);
        return cardObj;
    }
    public void Start()
    {
        CreateCard(cardPrefab.GetComponent<CardView>().card);
    }
}
