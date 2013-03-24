using UnityEngine;
using System.Collections;
using System;

public abstract class BaseCapacity : MonoBehaviour
{
	/// <summary>
	/// Cooldown en secondes
	/// </summary>
	public float CoolDown;
	public float LastActivity;
	public string Key;
	public string CapacityName;
	public Texture2D GUIPicture;
    public AudioClip Sound;
    public int Volume;
    public string AnimationName;

	//[HideInInspector]
	public VehicleController ParentVehicle;

    private Transform myTransform;

    public void Start()
    {
        myTransform = transform;
        this.ParentVehicle = this.transform.gameObject.GetComponentInChildren<VehicleController>();
        this.LastActivity = - this.CoolDown;
    }

    public virtual void ApplyCapacity()
    {
        this.LastActivity = Time.time;
        if (Sound != null)
            AudioSource.PlayClipAtPoint(Sound, myTransform.position, Volume);

        if (!String.IsNullOrEmpty(this.AnimationName))
        {
            this.ParentVehicle.animation.Play(this.AnimationName);
        }

        Debug.Log(this.CapacityName + " " + this.LastActivity.ToString());
    }
}
