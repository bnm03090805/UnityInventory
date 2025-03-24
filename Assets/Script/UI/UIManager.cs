using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] UIMainMenu uIMainMenu;
    [SerializeField] UIStatus uIStatus;
    [SerializeField] UIInventory uIInventory;

    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new GameObject("UIManager").AddComponent<UIManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance != null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(_instance != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
