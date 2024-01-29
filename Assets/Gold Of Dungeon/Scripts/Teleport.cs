using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget; // Iþýnlama yapýlacak hedef nokta

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TeleportPlayer(other.transform);
        }
    }

    void TeleportPlayer(Transform playerTransform)
    {
        // Oyuncuyu hedef noktaya ýþýnla
        playerTransform.position = teleportTarget.position;
    }
}
