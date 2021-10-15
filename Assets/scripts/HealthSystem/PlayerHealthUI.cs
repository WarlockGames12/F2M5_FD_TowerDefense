using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{

    [SerializeField] private Text _text;

    

    public void UpdateUI(float NumberOfLives)
    {
        _text.text = "Player Lives: " + NumberOfLives;
    }
}
