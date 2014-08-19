using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem))]
public class DistruggiEffetto : MonoBehaviour {

	private ParticleSystem effetto;

	// Use this for initialization
	void Start () {
		effetto = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!effetto.isPlaying)
			Destroy (gameObject);
	}
}
