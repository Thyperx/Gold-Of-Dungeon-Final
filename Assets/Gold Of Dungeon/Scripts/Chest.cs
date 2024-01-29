using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public int health;
    [SerializeField] private int scoreValue;


    void Start()
    {
       
    }

    
    void Update()
    {
        
    }
    
    

    public void TakeDamage(int damage)
    {
        health -= damage;

        
        if (health <= 0)
        {
            Score.Instance.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
