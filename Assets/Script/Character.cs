using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Level { get; private set; }
    public int MaxExp {  get; private set; }
    public int Exp { get; private set; }
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float HP { get; private set; }
    public float Critical { get; private set; }
    public float Gold { get; private set; }

    public float AtkModifier { get; private set; }
    public float DefModifier { get; private set; }
    public float HPModifier { get; private set; }
    public float CriticalModifier { get; private set; }

    public UIInventory Inventory { get; private set; }

    public Character(string name, string description, int level, int maxExp, int exp, float atk,float def, float hp, float critical, float gold, float atkModifier,float defModifier,float HPModifier,float criModifier, UIInventory uIInventory)
    {
        this.Name = name;
        this.Description = description;
        this.Level = level;
        this.MaxExp = maxExp;
        this.Exp = exp;
        this.Atk = atk;
        this.Def = def;
        this.HP = hp;
        this.Critical = critical;
        this.Gold = gold;
        this.AtkModifier = atkModifier;
        this.DefModifier = defModifier;
        this.HPModifier = HPModifier;
        this.CriticalModifier = criModifier;
        Inventory = uIInventory;
    }

    
}
