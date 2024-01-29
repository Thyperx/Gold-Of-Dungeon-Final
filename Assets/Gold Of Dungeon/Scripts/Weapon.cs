using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage = 10;
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        // Eðer çarptýðýmýz nesnenin bir "Chest" tag'ine sahip olduðunu kontrol ediyoruz
        if (other.CompareTag("Chest"))
        {
            // Chest script'ini alýyoruz
            Chest chest = other.GetComponent<Chest>();

            // Eðer chest script'i varsa, chest nesnesine zarar ver
            if (chest != null)
            {
                chest.TakeDamage(damage);
            }

        }
    }
    
}
