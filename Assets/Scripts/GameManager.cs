using UnityEngine;

public class GameManager : MonoBehaviour
{

    // 'score' is a value type variable (int). Value type variables store the data directly
    // on the stack. When value type variables are passed to methods or assigned to other
    // value type variables, a copy of the original value is created.
    public int score;

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }

    // The 'gameObject' property inherited from MonoBehaviour is an example of a reference
    // type variable. Reference type variables store a reference to the actual data on the
    // heap. When reference type variables are passed to methods or assigned to other
    // reference type variables, they still refer to the same data on the heap. Changes
    // made to the data through one reference are visible to other references as well.
    //
    // In this script, the 'gameObject' property is used implicitly when accessing the
    // 'transform' and 'GetComponent()' methods. These methods, in turn, access data on
    // the heap through the reference stored in the 'gameObject' property.
}