using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor,
    Helmet,
    Accessories
}
public class ItenData : ScriptableObject
{
    [SerializeField]
    public string itemName;
    public ItemType type;
    public string Description;
    public float Atk;
    public float Def;
    public float HP;
    public float Cri;
}
