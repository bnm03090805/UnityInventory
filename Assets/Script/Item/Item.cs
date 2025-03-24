using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name {  get; private set; }
    public string Description { get; private set; }
    public ItemType Type { get; private set; }
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float HP {  get; private set; }
    public float Cri { get; private set; }

    [SerializeField] private ItenData data;

    public Item(ItenData data)
    {
        this.Name = data.name;
        this.Description = data.Description;
        this.Type = data.type;
        this.Atk = data.Atk;
        this.Def = data.Def;
        this.HP = data.HP;
        this.Cri = data.Cri;
    }
}
