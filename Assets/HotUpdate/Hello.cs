using System.Collections;
using UnityEngine;

public class Hello
{
    public static void Run()
    {
        Debug.Log("Hello, HybridCLR");
        Debug.Log("Hello, HotUpdate World");

        GameObject go = new GameObject("Test1");
        go.AddComponent<Print>();
    }

}