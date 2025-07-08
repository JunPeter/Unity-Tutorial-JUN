using UnityEngine;

public class StringArray : MonoBehaviour
{
    string str = string.Empty;

    public string str1 = "Hello World*";

    private void Start()
    {
        Debug.Log(str1);

        Debug.Log(str1.Trim());

        str = str1.Trim('*');
        Debug.Log(str);

        Debug.Log(str1.Replace("Hello", "Bye"));
    }
}
