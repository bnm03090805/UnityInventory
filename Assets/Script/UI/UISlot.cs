using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Image equipIcon;
    [SerializeField] private Button btn;

    // Start is called before the first frame update
    void Start()
    {
        SetItem();
        RefreshUI();
    }


    void SetItem()
    {

    }

    void RefreshUI()
    {

    }
}
