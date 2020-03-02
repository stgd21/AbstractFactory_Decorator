using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemClient : MonoBehaviour
{
    public Dropdown itemTypeDropdown;
    public Dropdown itemSizeDropdown;
    public Dropdown itemColorDropdown;

    [Header("Default values to what the sliders are")]
    public ItemType type = ItemType.Health;
    public ItemSize size = ItemSize.Small;
    public ItemColor color = ItemColor.None;

    private ItemRequirements clientRequirements;
    private IItem newItem;

    private void Start()
    {
        clientRequirements = new ItemRequirements();
        clientRequirements.itemColor = color;
        clientRequirements.itemSize = size;
        clientRequirements.itemType = type;
    }

    private IItem GetItem(ItemRequirements requirements)
    {
        ItemFactory factory = new ItemFactory(requirements);
        switch (requirements.itemColor)
        {
            case ItemColor.None:
                newItem = factory.Create();
                newItem.Spawn();
                return newItem;
            case ItemColor.Red:
                newItem = new RedDecorator(factory.Create());
                return newItem;
            case ItemColor.Blue:
                newItem = new BlueDecorator(factory.Create());
                return newItem;
            default:
                newItem = factory.Create();
                newItem.Spawn();
                return newItem;
        }
    }

    public void Create()
    {
        newItem = GetItem(clientRequirements);
        //newItem.Spawn();
    }

    public void SetNewType()
    {
        switch (itemTypeDropdown.value)
        {
            case 0:
                clientRequirements.itemType = ItemType.Health;
                break;
            case 1:
                clientRequirements.itemType = ItemType.Ammo;
                break;
        }

    }

    public void SetNewSize()
    {
        switch (itemSizeDropdown.value)
        {
            case 0:
                clientRequirements.itemSize = ItemSize.Small;
                break;
            case 1:
                clientRequirements.itemSize = ItemSize.Medium;
                break;
            case 2:
                clientRequirements.itemSize = ItemSize.Large;
                break;
        }

    }

    public void SetNewColor()
    {
        switch (itemColorDropdown.value)
        {
            case 0:
                clientRequirements.itemColor = ItemColor.None;
                break;
            case 1:
                clientRequirements.itemColor = ItemColor.Red;
                break;
            case 2:
                clientRequirements.itemColor = ItemColor.Blue;
                break;
        }
    }

    public void DestroyAll()
    {
        GameObject[] allCharacters = GameObject.FindGameObjectsWithTag("Item");
        for (int i = 0; i < allCharacters.Length; i++)
            Destroy(allCharacters[i]);
    }
}
