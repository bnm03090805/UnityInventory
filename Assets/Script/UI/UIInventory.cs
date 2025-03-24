using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{

    [SerializeField] private GameObject uiInventory;
    [SerializeField] private Button mainBtn;

    private void Awake()
    {
        UIManager.Instance.UIInventory = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        mainBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
    }
}
