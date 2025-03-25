using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Weapon,
    Armor,
    Helmet,
    Ac
}
public class Item
{
    public string Name {  get; private set; }
    public string Description { get; private set; }
    public Sprite Icon { get; private set; }
    public ItemType Type { get; private set; }
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float HP {  get; private set; }
    public float Cri { get; private set; }

    public Item(string name, string description, Sprite icon, ItemType type, float atk, float def, float hp, float cri)
    {
        this.Name = name;
        this.Description = description;
        this.Icon = icon;
        this.Type = type;
        this.Atk = atk;
        this.Def = def;
        this.HP = hp;
        this.Cri = cri;
    }
}
