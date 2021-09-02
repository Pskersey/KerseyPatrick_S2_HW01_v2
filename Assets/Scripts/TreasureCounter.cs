using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureCounter : MonoBehaviour
{
    
    [SerializeField] Player player;
    public Text textElement;
    private void Start()
    {
        textElement.text = "Treasure: " + player._currentTreasure;
    }

    private void Update()
    {
        textElement.text = "Treasure: " + player._currentTreasure;
    }
    
}