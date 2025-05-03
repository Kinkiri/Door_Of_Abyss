using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Effect", menuName = "Effect")]
public abstract class Effect : ScriptableObject
{
    public abstract void ApplyEffect();
}
