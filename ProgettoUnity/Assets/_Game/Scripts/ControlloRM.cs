using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class ControlloRM : MonoBehaviour {

    private Animator anim;
    private CapsuleCollider capsula;
    private float altezzaCapsula;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        capsula = GetComponent<CapsuleCollider>();
        altezzaCapsula = capsula.height;
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            z /= 2f;
        anim.SetFloat("direzione", x);
        anim.SetFloat("velocita", z);

        if (Input.GetKeyDown(KeyCode.Space))
            anim.SetTrigger("salta");

        //if (anim.GetCurrentAnimatorStateInfo(0).IsName("salto"))
        //    capsula.height = altezzaCapsula * anim.GetFloat("curvaSalto");
        //else
        //    capsula.height = altezzaCapsula;
    }

    void SetCapsula(float quanto)
    {
        capsula.height = altezzaCapsula * quanto;
    }
}
