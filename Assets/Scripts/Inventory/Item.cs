using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    public TileBase title;
    public Sprite image;
    public ItemType type;
    public bool stackable = false;
}

public enum ItemType
{
    Tool,
    Material
}
