using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{

    [SerializeField] private GameObject uiInventory;
    [SerializeField] private Button mainBtn;
    [SerializeField] private UISlot slotPrefab;
    public List<UISlot> slots;
    public List<Item> datas;
    [SerializeField] private Transform slotParent;
    [SerializeField] private TextMeshProUGUI inventoryText;


    private void Awake()
    {
        UIManager.Instance.UIInventory = this;
        slots = new List<UISlot>();
        datas = new List<Item>();
        //Debug.Log(slots.Count);
    }

    void Start()
    {
        this.gameObject.SetActive(false);
        mainBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
        GameManager.Instance.Player.AddItem();
        InitUiInventory();
    }

    void InitUiInventory()
    {
        RefreshUI();
        inventoryText.text = $"{slots.Count} / {GameManager.Instance.Items.Count}";
    }

    public void RefreshUI()
    {
        if (datas.Count < 1)
            return;

        for (int i = 0; i < slots.Count; i++)
        {
            slots[i].RefreshUI();
        }

        for (int i = slots.Count; i < datas.Count; i++)
        {
            UISlot go = Instantiate(slotPrefab, slotParent);
            go.inventory = this;
            go.SetItem(i);
            slots.Add(go);
        }

        inventoryText.text = $"{slots.Count} / {GameManager.Instance.Items.Count}";
    }
}
