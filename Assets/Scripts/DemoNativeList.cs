using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;


public class DemoNativeList : MonoBehaviour
{
    NativeList<int> list;

    public struct testStruct<T> where T : struct { };

    void Start()
    {
        list = new NativeList<int>(10, Allocator.TempJob);
        list.Add(0);
        list.Add(1);

        for(int i = 0; i <list.Length; i++)
        {
            Debug.Log("i = " + list[i]);
        }
        list.Dispose();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
