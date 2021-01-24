using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanuki : MonoBehaviour
{
    // ・クリックされたときに
    // ・Leafを持っていれば
    // ・消える

    public void OnThis()
    {
        bool hasLeaf = ItemBox.instance.CanUseItem(ItemManager.Item.Leaf);
        if (hasLeaf == true)
        {
            gameObject.SetActive(false);
            ItemBox.instance.UseItem(ItemManager.Item.Leaf);
        }
    }

}