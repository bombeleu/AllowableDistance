using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	void OnEnterAllowableDistance( Transform other )
	{
		print("Entrei" + ":: " + other.name);
	}
	void OnExitAllowableDistance( Transform other )
	{
		print("Sai" + ":: " + other.name);
	}
	void OnStayAllowableDistance( Transform other )
	{
		print("Estrou dentro" + ":: " + other.name );
	}
}
