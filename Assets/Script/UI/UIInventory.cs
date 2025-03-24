using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{

    [SerializeField] private GameObject uiInventory;
    [SerializeField] private Button mainBtn;

    [SerializeField] private UISlot slotPrefab;
    UISlot[] slots;
    [SerializeField] private Transform slotParent;

    private void Awake()
    {
        UIManager.Instance.UIInventory = this;
    }

    void Start()
    {
        this.gameObject.SetActive(false);
        mainBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
        InitUiInventory();
    }

    void InitUiInventory()
    {
        for(int i = 0; i < 20; i++)
        {
            Instantiate(slotPrefab, slotParent);
        }
    }
}
