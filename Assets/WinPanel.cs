using System.Security.Cryptography;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    private Transform CanvasWinPanel;
    private bool _isShownWinPanel = false;
    private int _totalCoinObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CanvasWinPanel = transform.Find("Canvas");
        _totalCoinObjects = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isShownWinPanel)
        {
            if (FindFirstObjectByType<CoinCounter>().CoinAmount == _totalCoinObjects)
            {
                CanvasWinPanel.gameObject.SetActive(true);
                _isShownWinPanel = true;
            }
        }      
    }
}
