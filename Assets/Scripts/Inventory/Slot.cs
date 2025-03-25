using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private InventoryManager inventory;
    public int index;
    public Image image;
    public Color selected, notSelected;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryManager>();
    }

    public void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull[index] = false;
        }
    }

    private void Awake()
    {
        Deselect();
    }

    public void Select() 
    { 
        image.color = selected;
    }

    public void Deselect()
    {
        image.color = notSelected;
    }

    public void Drop()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Spawn>().SpawnItem();
            GameObject.Destroy(child.gameObject);
        }
    }

}
