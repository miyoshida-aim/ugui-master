using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;


public class Data1
{
    public int a;
    public int b;
}

public class Data2
{
    public int c;
    public int d;
}

public struct ST_Data1
{
    public Data1 data1;
    public Data1 data2;
    public int a;
    public int b;
    public int c;
    public Data2 data2_1;
    public Data2 data2_2;
}

public class CL_Data1
{
    public Data1 data1;
    public Data1 data2;
    public int a;
    public int b;
    public int c;
    public Data2 data2_1;
    public Data2 data2_2;
}

public class UseMemoryTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Profiler.BeginSample("data1");
        var data1 = new Data1();    //0B
        Profiler.EndSample();

        Profiler.BeginSample("st_data1");
        var st_data1 = new ST_Data1();    //0B
        Profiler.EndSample();

        Profiler.BeginSample("st_data1=data1");
        st_data1.data1 = data1;    //0B
        Profiler.EndSample();

        Profiler.BeginSample("cl_data1");
        var cl_data1 = new CL_Data1();    //64B
        Profiler.EndSample();

        Profiler.BeginSample("cl_data1=data1");
        cl_data1.data1 = data1;    //24B
        Profiler.EndSample();
    }

    // Update is called once per frame
    void Update()
    {
    }
}