using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject uiMainMenu;
    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private TextMeshProUGUI playerLv;
    [SerializeField] private Image expBar;
    [SerializeField] private TextMeshProUGUI playerExp;
    [SerializeField] private TextMeshProUGUI playerDescripition;
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;

    Character player;

    private void Awake()
    {
        UIManager.Instance.UIMainMenu = this;
        
    }
    void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
        player = GameManager.Instance.Player;
        UpdatePlayerInfo();
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.UIInventory.gameObject.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
        UpdatePlayerInfo();
    }

    public void OpenStatus()
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
        UIManager.Instance.UIStatus.UpdateUI();
    }

    public void OpenInventory()
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false);
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
        UIManager.Instance.UIInventory.RefreshUI();
    }

    public void UpdatePlayerInfo()
    {
        playerName.text = $"{player.Name}";
        playerLv.text = $"{player.Level}";
        playerDescripition.text = $"{player.Description}";
        playerExp.text = $"{player.Exp} / {player.MaxExp}";
        expBar.fillAmount = (float)player.Exp / (float)player.MaxExp;
    }
}
