
using System.Collections.Generic;
using UnityEngine;

public class StudyStack : MonoBehaviour
{
    public Stack<int> stack = new Stack<int>();

    private void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            stack.Push(i);
        }

        Debug.Log(stack.Pop());

        Debug.Log(stack.Peek());
    }
}
