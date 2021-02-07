using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    // クリックした時に、鍵を持っていれば Openにする
    // 持っていなければログを出す
    public GameObject openObj;

    public void OnThis()
    {
        bool hasKey = ItemBox.instance.CanUseItem(ItemManager.Item.Key);
        if (hasKey == true)
        {
            Open();
            ItemBox.instance.UseItem(ItemManager.Item.Key);
        }
        else
        {
            Debug.Log("鍵がかかっている");
        }
    }

    void Open()
    {
        // 開いている画像を表示
        openObj.SetActive(true);
    }
}