using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardView : MonoBehaviour
{
    public Card card;
    public GameObject UnitObject;
    public TextMeshProUGUI cardName;
    public TextMeshProUGUI cardDescription;
    public TextMeshProUGUI cardCost;
    public TextMeshProUGUI cardType;
    public Image cardImage;
    public Image cardBack;
    public bool isUnitCard => card.type == CardType.Unit;
    public TextMeshProUGUI cardHealth;
    public TextMeshProUGUI cardAttack;

    public void UpdateVisuals(Card card)
    {
        this.card = card;
        cardName.text = card.cardName;
        cardDescription.text = card.description;
        cardCost.text = card.cost.ToString();
        cardType.text = card.type.ToString();
        cardImage.sprite = card.cardImage;
        cardBack.sprite = card.cardBack;
        if (isUnitCard)
        {
            UnitObject.SetActive(true);
            UnitCard unitCard = (UnitCard)card;
            cardHealth.text = unitCard.health.ToString();
            cardAttack.text = unitCard.attack.ToString();
        }
        else
        {
            UnitObject.SetActive(false);
        }
    }
    public void Start()
    {
        UpdateVisuals(card);
    }
}
