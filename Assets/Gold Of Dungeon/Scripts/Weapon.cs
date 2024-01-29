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
        // E�er �arpt���m�z nesnenin bir "Chest" tag'ine sahip oldu�unu kontrol ediyoruz
        if (other.CompareTag("Chest"))
        {
            // Chest script'ini al�yoruz
            Chest chest = other.GetComponent<Chest>();

            // E�er chest script'i varsa, chest nesnesine zarar ver
            if (chest != null)
            {
                chest.TakeDamage(damage);
            }

        }
    }
    
}
