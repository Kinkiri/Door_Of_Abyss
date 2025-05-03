using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public enum CardType { Unit, Spell, Equipment, Field }
/// <summary>
/// 
/// </summary>
public enum CardTag {  }

/// <summary>
/// 卡牌基类
/// </summary>
public class Card : ScriptableObject
{
    public string cardID; // 
    public string cardName; // 
    public int cost; // 
    public CardType type;  // 
    public List<CardTag> tags; // 
    public string description;  // 
    public List<Effect> effects; // 
    public Sprite cardImage;  // 
    public Sprite cardBack;  //
    public int maxInDeck = 5; // 
}
