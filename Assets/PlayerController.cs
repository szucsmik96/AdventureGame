using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Animator animator;
	private float speed = 1f;
	private float damage = 50f;

//	public bool canMove = true;

	// Use this for initialization
	void Start () {
		animator = GetComponentInChildren<Animator> ();
	}

	// Update is called once per frame
	void Update () {
			if (Input.GetKey (KeyCode.A)) {
				transform.position += Vector3.left * Time.deltaTime * speed;
				animator.SetBool ("isWalkingLeft", true);
				animator.SetBool ("isWalkingRight", false);
			} else if (Input.GetKey (KeyCode.D)) {
				transform.position += Vector3.right * Time.deltaTime * speed;
				animator.SetBool ("isWalking", true);
				animator.SetBool ("isWalkingLeft", false);
				animator.SetBool ("isWalkingRight", true);
			} else if (Input.GetKey (KeyCode.W)) {
				transform.position += Vector3.up * Time.deltaTime * speed;
				animator.SetBool ("isWalking", true);
				animator.SetBool ("isWalkingLeft", false);
				animator.SetBool ("isWalkingRight", true);
			} else if (Input.GetKey (KeyCode.S)) {
				transform.position += Vector3.down * Time.deltaTime * speed;
				animator.SetBool ("isWalking", true);
				animator.SetBool ("isWalkingLeft", false);
				animator.SetBool ("isWalkingRight", true);
			} else {
				animator.SetBool ("isWalking", false);
				animator.SetBool ("isWalkingLeft", false);
				animator.SetBool ("isWalkingRight", false);
			}

		if (Input.GetKey (KeyCode.Space)) {
			animator.SetBool ("isAttacking", true);
		} else {
			animator.SetBool ("isAttacking", false);
		}
	}
}
