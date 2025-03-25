using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Character
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

    public float AtkModifier { get; set; }
    public float DefModifier { get; set; }
    public float HPModifier { get;  set; }
    public float CriticalModifier { get; set; }

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


    public void AddItem()
    {
        Item item = GameManager.Instance.Items[UnityEngine.Random.Range(0, GameManager.Instance.Items.Count)];
        for(int i = 0; i<Inventory.slots.Count; i++)
        {
            if (Inventory.slots[i].Item.Name == item.Name)
            {
                Inventory.slots[i].quantity++;
                Debug.Log($"AddItem호출 {item.Name} Count : {Inventory.slots[i].quantity}");
                Inventory.RefreshUI();
                return;
            }
        }
        GameManager.Instance.Player.Inventory.datas.Add(item);
        Debug.Log($"AddItem호출 {item.Name}");
        Inventory.RefreshUI();
    }

    public void Equip(int index)
    {
        if (GameManager.Instance.Player.Inventory.datas[index].isEquip)
        {
            UnEquip(index);
            return;
        }
        GameManager.Instance.Player.Inventory.datas[index].isEquip = true;
        GameManager.Instance.Player.AtkModifier += GameManager.Instance.Player.Inventory.datas[index].Atk;
        GameManager.Instance.Player.DefModifier += GameManager.Instance.Player.Inventory.datas[index].Def;
        GameManager.Instance.Player.HPModifier += GameManager.Instance.Player.Inventory.datas[index].HP;
        GameManager.Instance.Player.CriticalModifier += GameManager.Instance.Player.Inventory.datas[index].Cri;
        Debug.Log("능력치 상승");
        Debug.Log($"ATK:{GameManager.Instance.Player.AtkModifier} DEF : {GameManager.Instance.Player.DefModifier}, HP : {GameManager.Instance.Player.HPModifier}, Cri : {GameManager.Instance.Player.CriticalModifier}");
        GameManager.Instance.Player.Inventory.RefreshUI();
    }

    public void UnEquip(int index)
    {
        GameManager.Instance.Player.Inventory.datas[index].isEquip = false;
        GameManager.Instance.Player.AtkModifier -= GameManager.Instance.Player.Inventory.datas[index].Atk;
        GameManager.Instance.Player.DefModifier -= GameManager.Instance.Player.Inventory.datas[index].Def;
        GameManager.Instance.Player.HPModifier -= GameManager.Instance.Player.Inventory.datas[index].HP;
        GameManager.Instance.Player.CriticalModifier -= GameManager.Instance.Player.Inventory.datas[index].Cri;
        Debug.Log("능력치 저하");
        Debug.Log($"ATK:{GameManager.Instance.Player.AtkModifier} DEF : {GameManager.Instance.Player.DefModifier}, HP : {GameManager.Instance.Player.HPModifier}, Cri : {GameManager.Instance.Player.CriticalModifier}");
        GameManager.Instance.Player.Inventory.RefreshUI();
    }
}
