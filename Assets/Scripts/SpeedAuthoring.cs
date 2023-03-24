using System;
using UnityEngine;
using Unity.Entities;
public class SpeedAuthoring : MonoBehaviour
{

    public float speedValue;

}

public class SpeedBaker : Baker<SpeedAuthoring>
{
    public override void Bake(SpeedAuthoring authoring)
    {
        AddComponent(new Speed
        {
            value = authoring.speedValue
        });
    }
}
