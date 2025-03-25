using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public bool[] isFull;
    public Slot[] slots;
    public GameObject inventory;
    private bool isOn;

    int selectedSlot = -1;

    void ChangeSelectedSlot(int value)
    {
        if (selectedSlot >= 0)
        {
            slots[selectedSlot].Deselect(); 
        }
        slots[value].Select();
        selectedSlot = value;
    }

    private void Start()
    {
        isOn = false;
        inventory.SetActive(false);
    }

    public void OpenClose()
    {
        if (isOn == false) { 
            isOn = true;
            inventory.SetActive(true);
        }
        else
        {
            isOn = false;
            inventory.SetActive(false);
        }
    }
}
