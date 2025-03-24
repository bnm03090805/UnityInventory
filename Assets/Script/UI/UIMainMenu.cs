using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject uiMainMenu;
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;

    private void Awake()
    {
        UIManager.Instance.UIMainMenu = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
        UIManager.Instance.UIStatus.mainBtn.onClick.AddListener(OpenMainMenu);
        UIManager.Instance.UIInventory.mainBtn.onClick.AddListener(OpenMainMenu);
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.UIInventory.gameObject.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
    }

    public void OpenStatus()
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false);
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
    }

    
}
