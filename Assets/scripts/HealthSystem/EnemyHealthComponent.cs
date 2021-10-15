using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthComponent : HealthOponent
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
        }
        
    }

    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        //Update je health bar

    }

    protected override void Death()
    {
        base.Death();
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Debug.Log("It takes damage");
            TakeDamage(5);
        }
    }
}
