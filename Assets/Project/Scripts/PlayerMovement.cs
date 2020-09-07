using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerMovement : MonoBehaviour
{
    public Joystick joystick;
    public FixedButton jumpButton;
    public FixedTouchField touchField;

    public float runSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        jumpButton = FindObjectOfType<FixedButton>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 15, rigidbody.velocity.y, joystick.Vertical * 15);
    }

    public void MoveToRandomPosition()
    {
        float xMove = Random.Range(0, 22) - 12;
        float zMove = Random.Range(0, 17) - 7;

        var rb = GetComponent<RigidbodyFirstPersonController>();

        Vector3 pos = rb.transform.position;
        pos.x = xMove;
        pos.z = zMove;
        gameObject.transform.position = pos;

    }
}
