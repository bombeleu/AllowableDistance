using UnityEngine;
using System;
using System.Collections;

public class AllowableDistance: MonoBehaviour
{
<<<<<<< HEAD
	#region Public
	[HideInInspector]
	public float allowableDistance = 1.0f;
	#endregion
=======
	[HideInInspector]
	public float allowableDistance = 10.0f;

	private AllowableDistance Distance;
>>>>>>> origin/master

	#region Private
	private float currentDistance = 0.0f;

	private Transform target;
	private Transform myTransform;

	private bool isEnter = false;

	private AllowableDistance Distance;
	#endregion

	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Awake()
	{
		Distance = GetComponent<AllowableDistance>();
	}

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start() 
	{
		this.myTransform = this.transform;

		this.target = GameObject.FindGameObjectWithTag("Player").transform;
	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update()
	{
		this.currentDistance =  Vector3.Distance( this.target.position, this.myTransform.position );

		if(!this.isEnter)
		{
<<<<<<< HEAD
			if(this.currentDistance <= Distance.allowableDistance) {SendMessage("OnEnterAllowableDistance", target); this.isEnter = true;}
=======
			if(this.currentDistance <= Distance.allowableDistance)
			{  
				this.OnEnterAllowableDistance();
				this.isEnter = true;
			}
>>>>>>> origin/master
		}

		if(this.isEnter)
		{
<<<<<<< HEAD
			if(this.currentDistance <= Distance.allowableDistance) SendMessage("OnStayAllowableDistance", target);

			if(this.currentDistance > Distance.allowableDistance) {SendMessage("OnExitAllowableDistance", target); this.isEnter = false;}
=======
			if(this.currentDistance > Distance.allowableDistance)
				this.OnStayAllowableDistance();

			if(this.currentDistance > Distance.allowableDistance)
			{
				this.OnExitAllowableDistance();
				this.isEnter = false;
			}
>>>>>>> origin/master
		}
	}

	/// <summary>
	/// Raises the enter allowable distance event.
	void OnEnterAllowableDistance(Transform other)
	{
		// No implementation
	}
	/// <summary>
	/// Raises the exit allowable distance event.
	void OnExitAllowableDistance(Transform other)
	{
		// No implementation
	}

	/// <summary>
	/// Raises the stay allowable distance event.
	void OnStayAllowableDistance(Transform other)
	{
		// No implementation
	}
}
