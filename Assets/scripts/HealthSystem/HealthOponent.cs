using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthOponent : MonoBehaviour
{
    

    [SerializeField] private float _startHealth;
    private float _currentHealth;
    public float CurrentHealth { 
        get { return _currentHealth; } 
    }

    private void Awake()
    {
        _currentHealth = _startHealth;
    }

    

    public void TakeDamage(float Amount)
    {
        _currentHealth -= Amount;

        HandleTakeDamage();
        if (_currentHealth <= 0)
        {
            Death();
        }

    }

    protected virtual void HandleTakeDamage()
    {
        print("Ik krijg Damage");
    }

    protected virtual void Death()
    {
        print("Ik ga dood");
    }

}
