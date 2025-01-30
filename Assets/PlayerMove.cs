using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] float RotationSpeed;

    private void Start()
    {
      
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 offset = new Vector3(h, 0, v) * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(offset * 3);
        }
        else
        {
            transform.Translate(offset);
        }

        float yRotation = Input.GetAxis("Mouse X");
        transform.Rotate(0, yRotation * RotationSpeed * Time.deltaTime, 0);
    }
}
