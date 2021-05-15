using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float ForceValue = 2000f;
    public float sidewaysForce = 500f;
    public Rigidbody rb;
    float speed;

    void FixedUpdate()
    {
        Time.timeScale = 1f;
        rb.AddForce(0, 0, ForceValue * Time.deltaTime);
        float x = Input.GetAxis("Horizontal");
        speed = PlayerPrefs.GetFloat("Speed", 20);
        transform.Translate(x * Time.deltaTime * speed, 0, 0);
    }

    public void ChangeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
