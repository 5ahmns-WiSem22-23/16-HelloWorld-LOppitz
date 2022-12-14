
using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    //2) Instanzvariable nutzen
    int startValue2 = 0;

    //3) Wert der dazukommt ist bei Deklaration nicht bekannt
    // z.B. Random User Input
    private int startValue3 = 0;

    //4) Copy by Value
    private int startValue4 = 10;

    //Return
    private int startValue5 = 20;

    void Start()
    {
        //1) Verwende Start Methode
        Debug.Log("Hallo Methoden!");

        //at 2)   
        Debug.Log("startValue: " + startValue2);
        IncrementByOne();
        Debug.Log("new startValue: " + startValue2);

        //at 3)
        Debug.Log("before startValue3:" + startValue3);
        IncrementByX(Random.Range(1, 10));
        Debug.Log("after startValue3:" + startValue3);

        //at 4)
        Debug.Log("before startValue4:" + startValue4);
        DecrementByOne(startValue4);
        Debug.Log("after startValue4:" + startValue4);

        //at 5)
        Debug.Log("before startValue5:" + startValue5);
        startValue5 = DecrementByX(startValue5, 2);
        Debug.Log("after startValue5:" + startValue5);

    }

    //5) incl. return value
    private int DecrementByX(int start, int valToSub)
    {
        return start - valToSub;
    }

    private void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val:" + val);
    }
    private void IncrementByX(int valToAdd)
    {
        startValue3 += valToAdd;
    }

    private void IncrementByOne()
    {
        startValue2++;
        //startValue2 = startValue2 + 1;
    }
}
