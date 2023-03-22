using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 'speed' is a value type variable (float). Value type variables store the data
    // directly on the stack. When value type variables are passed to methods or assigned
    // to other value type variables, a copy of the original value is created.
    public float speed = 5f;

    // 'rb' is a reference type variable (Rigidbody). Reference type variables store a
    // reference to the actual data on the heap. When reference type variables are passed
    // to methods or assigned to other reference type variables, they still refer to the
    // same data on the heap. Changes made to the data through one reference are visible
    // to other references as well.
    private Rigidbody rb;

    void Start()
    {
        // 'GetComponent<Rigidbody>()' returns a reference to the Rigidbody component on
        // the same GameObject. This reference is stored in the 'rb' variable, and any
        // changes made to the Rigidbody component through 'rb' will affect the actual
        // data on the heap.
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        // 'moveHorizontal' and 'moveVertical' are value type variables (float). They store
        // their data directly on the stack, and when passed to methods or assigned to other
        // value type variables, a copy of the original value is created.
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // 'movement' is a value type variable (Vector3). Value type variables store the data
        // directly on the stack. When value type variables are passed to methods or assigned
        // to other value type variables, a copy of the original value is created.
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
}