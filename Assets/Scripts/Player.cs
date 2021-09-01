using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TankController))]
public class Player : MonoBehaviour
{
    [SerializeField] int _maxHealth = 3;
    int _currentHealth;

    TankController _tankController;

    private void Awake()
    {
        _tankController = GetComponent<TankController>();
    } // End of Awake

    // Start is called before the first frame update
    private void Start()
    {
        _currentHealth = _maxHealth;
    } // End of Start

    // Update is called once per frame
    void Update()
    {
        
    } //End of Update

    public void IncreaseHealth(int amount)
    {
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        Debug.Log("Player's Health : " + _currentHealth);
    } //End of Increase Health

    public void DecreaseHealth(int amount)
    {
        _currentHealth -= amount;
        Debug.Log("Player's Health : " + _currentHealth);
        if(_currentHealth <= 0)
        {
            Kill();
        }
    } // End of DecreaseHealth

    public void Kill()
    {
        gameObject.SetActive(false);
        // play particles
        // playsounds
    } //End of Kill
}