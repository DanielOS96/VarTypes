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
}
