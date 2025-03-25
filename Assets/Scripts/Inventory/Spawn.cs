using UnityEngine;
using UnityEngine.Rendering;
using static UnityEditor.Progress;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    public Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnItem()
    {
        Vector2 position = new Vector2(player.position.x, player.position.y - 1);
        Instantiate(item, position, Quaternion.identity);
    }
}


   