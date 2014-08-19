using UnityEngine;
using System.Collections;

public class Pedate : MonoBehaviour {

	public GameObject effetto;
	public Transform piedeDx;
	public Transform piedeSx;

	void SxPedata()
	{
		Instantiate (effetto, piedeSx.position, Quaternion.identity);
	}
	
	void DxPedata()
	{
		Instantiate (effetto, piedeDx.position, Quaternion.identity);
	}
	
}
