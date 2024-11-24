using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStaffShoot : MonoBehaviour
{	
	public float fireballSpeed = 100f;
	public Rigidbody2D rb;
	public AudioSource shootAudioSource;
	public AudioClip shootAudioClip;
	public AudioSource collisionAudioSource;
	public AudioClip collisionAudioClip;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
       	shootAudioSource.PlayOneShot(shootAudioClip);
        rb.velocity	= transform.up * fireballSpeed;
        rb.transform.Rotate(0.0f, 0.0f, 90.0f);
        Destroy(gameObject, 10f);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag != "Player" & hitInfo.gameObject.tag != "Roof" & hitInfo.gameObject.tag != "PassObjects" & hitInfo.gameObject.tag != "Projectile")
        {
       		shootAudioSource.Stop();
       		collisionAudioSource.PlayOneShot(collisionAudioClip);
       		rb.velocity	= transform.up * 0;
       		animator.Play("FireballDestroy", 0, 0f);
        	Destroy(gameObject, 1.55f);
        }
    }


}
