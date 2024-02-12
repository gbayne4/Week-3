using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    private int speed;
    private int jump;
    private int height;
    public int turnSpeed;

    private int changeColor;
    Vector3 left_EulerAnglerVelocity;
    Vector3 right_EulerAnglerVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        left_EulerAnglerVelocity = new Vector3(0, turnSpeed, 0);
        right_EulerAnglerVelocity = new Vector3(0, -turnSpeed, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {

        //if you hit an obstacle
        if (collision.gameObject.tag == "Loops") //if we collide with a game object whose tag is equal to ground
        {
            Destroy(collision.gameObject);
            CoinCalculator.coins -= 1;

        }


        if (collision.gameObject.tag == "Floor") //if we collide with a game object whose tag is equal to ground
        {
            jump = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
      //  Color newColor = (changeColor) ? new Color(0.4f, 0.9f, 0.7f, 1.0f): new Color(100f, 0.9f, 0.7f, 1.0f);

        //jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * height);
            jump += 1;
        }

        //adds in a otential triple jump, thats lowers in volume each time
        switch (jump)
        {
            case 1:
                height = 700;
                break;
            case 2:
                height = 500;
                break;
            case 3:
                height = 150;
                break;
            default:
                height = 0;
                break;
        }

            //movement

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(transform.forward * speed);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(-transform.forward * speed);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Quaternion deltaRotation = Quaternion.Euler(left_EulerAnglerVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Quaternion deltaRotation2 = Quaternion.Euler(right_EulerAnglerVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation2);
        }


    }
}
