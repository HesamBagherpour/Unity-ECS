using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.Jobs;

public partial class MoveingSystemBase : SystemBase
{
    protected override void OnUpdate()
    {
        foreach (LocalToWorld ts in SystemAPI.Query<LocalToWorld>())
        {
            var a = ts;
            Debug.Log("aaaaaaaaaa");
         
        }
    }
}