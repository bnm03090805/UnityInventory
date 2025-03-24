using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{

    [SerializeField] private GameObject uiStatus;
    [SerializeField] private Button mainBtn;
    [SerializeField] private TextMeshProUGUI atkText;
    [SerializeField] private TextMeshProUGUI defText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI criText;
    Character player;

    private void Awake()
    {
        UIManager.Instance.UIStatus = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameManager.Instance.Player;
        this.gameObject.SetActive(false);
        mainBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
    }


    public void UpdateUI()
    {
        atkText.text = $"{player.Atk + player.AtkModifier}";
        defText.text = $"{player.Def + player.DefModifier}";
        hpText.text = $"{player.HP + player.HPModifier}";
        criText.text = $"{player.Critical + player.CriticalModifier}";
    }
}
