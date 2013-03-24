using UnityEngine;
using System.Collections;

public class Dash : BaseCapacity
{
    public Dash()
    {
        this.CapacityName = "Dash";
        this.Key = "&";
        this.CoolDown = 3f;
        this.AnimationName = "";
    }

    public override void ApplyCapacity()
    {
        base.ApplyCapacity();
        //TODO : code du Dash
		this.ParentVehicle.rigidbody.AddForce(500000f, 0f, 0f, ForceMode.Force);
    }
}
