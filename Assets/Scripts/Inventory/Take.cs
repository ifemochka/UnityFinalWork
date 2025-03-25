using UnityEngine;

public class Take : MonoBehaviour
{
    private InventoryManager inventory;
    public GameObject slot;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(slot, inventory.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
