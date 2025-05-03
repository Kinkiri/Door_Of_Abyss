using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "New Unit Card", menuName = "Card/Unit Card")]
public class UnitCard : Card
{
    public Unit unit;
    public int attack => unit.attack;
    public int health => unit.health;
}
