using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.Jobs;

public partial class MoveingSystemBase : SystemBase
{
    protected override void OnUpdate()
    {
        foreach (LocalTransform ts in SystemAPI.Query<LocalTransform>())
        {
            var a = ts;
            a.Position.x = 50;
        }
    }
}