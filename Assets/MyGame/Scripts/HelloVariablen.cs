using UnityEngine;

public class HelloVariablen : MonoBehaviour
{
    //Value Typs: Wert wird im Speicher direkt hinterlegt
    int myInt = 0;
    bool myBool = true;
    string a = "Hallo";

    int[] myArray = new int[3] { 0, 0, 0 };
    void Start()
    {
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(bool));

        //Value Type
        int tmp = myInt;
        myInt++;
        Debug.Log(" myInt: " + myInt + " tmp " + tmp);

        //Reference Type
        int[] tmpArray = myArray;
        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;

        foreach(int a in tmpArray)
        {
            Debug.Log(a);
        }

        foreach (int a in myArray)
        {
            Debug.Log(a);
        }
        string tmpString = a;
        a = "hello";
        Debug.Log("a " + a + " tmpString " + tmpString);
    }

    

}
