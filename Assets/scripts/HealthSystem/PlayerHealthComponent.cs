using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealthComponent : HealthOponent
{
    [SerializeField] private PlayerHealthUI _playerHealthUI;
    private void Start()
    {
        _playerHealthUI.UpdateUI(CurrentHealth);
    }

    protected override void Death()
    {
        base.Death();
        print("Laad level in, of game over menu");
        SceneManager.LoadScene("Prototype");
    }

    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        //update je levens
        _playerHealthUI.UpdateUI(CurrentHealth);
    }
}
