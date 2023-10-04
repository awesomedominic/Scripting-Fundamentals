using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FunctionsandMethods : MonoBehaviour
{
    public int Score = 0;

    private int _playerHealthAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method Examples

    // This method is accessible from other files because it is public
    public void UpdatePlayerHealth(int amount)
    {
        _playerHealthAmount = amount;
    }

    // This method is not accessable from other files
    private void IncreaseScore()
    {
        Score++; // Score = Score + 1;
    }

    private void MovePlayer()
    {
        transform.Translate(Vector3.forward);
    }
}
