using System.Collections;
using System.Collections.Generic;
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

    private void Awake()
    {
        UIManager.Instance.UIInventory = this;
        slots = new List<UISlot>();
        datas = new List<Item>();
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
        for(int i = 0; i < datas.Count; i++)
        {
            //Instantiate(slotPrefab, slotParent);
            UISlot go = Instantiate(slotPrefab, slotParent);
            go.inventory = this;
            go.SetItem(i);
            slots.Add(go);
        }
    }
}
