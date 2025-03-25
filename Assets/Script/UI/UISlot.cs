using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Item Item { get; private set; }
    [SerializeField] private Image Icon;
    [SerializeField] private Outline outline;
    [SerializeField] private Button btn;
    [SerializeField] private TextMeshProUGUI quantityText;

    public int index;
    public UIInventory inventory;
    [HideInInspector]
    public int quantity;

    private void Start()
    {
        btn.onClick.AddListener(() => GameManager.Instance.Player.Equip(index));
        quantity = 1;
    }

    public void SetItem(Item item)
    {
        this.Item = item;
    }

    public void SetItem(int i)
    {
        index = i;
        this.Item = inventory.datas[index];
        RefreshUI();
    }

    public void RefreshUI()
    {
        if(Item != null)
        {
            Icon.sprite = Item.Icon;
            outline.enabled = Item.isEquip;
            quantityText.text = $"{quantity}";
        }
    }

}
