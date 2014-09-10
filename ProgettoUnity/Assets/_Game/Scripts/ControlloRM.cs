using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class ControlloRM : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            z /= 2f;
        anim.SetFloat("direzione", x);
        anim.SetFloat("velocita", z);
    }
}
