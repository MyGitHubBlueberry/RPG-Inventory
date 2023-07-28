using UnityEngine;
using GameDevTV.Inventories;
using InventoryExample.Control;

namespace InventoryExample.Control
{
    [RequireComponent(typeof(Pickup))]
    public class RunoverPickup : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Player"))
            {
                GetComponent<Pickup>().PickupItem();
            }
        }
    }
}