using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public UIMainMenu _UIMainMenu;
    public UIStatus _UIStatus;
    public UIInventory _UIInventory;
    public UIMainMenu UIMainMenu
    {
        get { return _UIMainMenu;  }
        set { _UIMainMenu = value; }
    }
    public UIStatus UIStatus
    {
        get { return _UIStatus; }
        set { _UIStatus = value; }
    }
    public UIInventory UIInventory
    {
        get { return _UIInventory; }
        set { _UIInventory = value; }
    }

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
