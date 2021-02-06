using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public enum Item
    {
        Leaf,
        Key,
        Card,
        Hammer,
        Paper,
    }

    public Item item;

    // クリックされた時に、
    public void OnTihs()
    {
        // ・消す
        gameObject.SetActive(false);

        // ・ItemBoxに追加する
        ItemBox.instance.SetItem(item);
    }

}
