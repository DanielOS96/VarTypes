using UnityEngine;

public class Coin : MonoBehaviour
{
    // 'gameManager' is a reference type variable (GameManager). Reference type variables
    // store a reference to the actual data on the heap. When reference type variables are
    // passed to methods or assigned to other reference type variables, they still refer to
    // the same data on the heap. Changes made to the data through one reference are visible
    // to other references as well.
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        // 'other' is a reference type variable (Collider). Reference type variables store a
        // reference to the actual data on the heap. When reference type variables are passed
        // to methods or assigned to other reference type variables, they still refer to the
        // same data on the heap. Changes made to the data through one reference are visible
        // to other references as well.

        // 'gameObject' and 'other.gameObject' are reference type variables that store references
        // to different objects on the heap. Comparing the tags of these objects does not
        // involve copying the objects themselves, but rather just the references.

        if (other.gameObject.CompareTag("Player"))
        {
            // '1' is a value type variable (int). Value type variables store the data directly
            // on the stack. When value type variables are passed to methods or assigned to other
            // value type variables, a copy of the original value is created.
            gameManager.AddScore(1);

            // The 'Destroy' method takes a reference type variable (GameObject) as an argument.
            // It does not create a copy of the object but works with the reference to the object
            // on the heap to mark it for destruction.
            Destroy(gameObject);
        }
    }
}