using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    Soldier,
    Building
}
/// <summary>
/// 
/// </summary>
public class Unit : MonoBehaviour
{
    public int attack;
    public int health;
    public GameObject unitPrefab;
    public UnitType unitType;
}
