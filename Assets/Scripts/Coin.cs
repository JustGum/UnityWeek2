using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float RotationCoinSpeed;
    private Transform _playerTransform;
    private void Start()
    {
        //_objectRigidbody.isKinematic = false;
        //transform.position = new Vector3(0, 0, 0);
        //PlayerTransform = GameObject.Find("Capsule").transform;
        //PlayerTransform = GameObject.FindWithTag("Player").transform;
        //PlayerTransform = FindObjectOfType<PlayerMove>().gameObject.transform;
        _playerTransform = FindFirstObjectByType<PlayerMove>().gameObject.transform;
    }
    void Update()
    {
        transform.Rotate(0, 0, RotationCoinSpeed * Time.deltaTime);

        float distance = Vector3.Distance(transform.position, _playerTransform.position);
        //Debug.Log(distance);
        if (distance < 0.8f)
        {
            FindFirstObjectByType<CoinCounter>().CoinAmount += 1;
            Destroy(gameObject);
        }
    }
}
