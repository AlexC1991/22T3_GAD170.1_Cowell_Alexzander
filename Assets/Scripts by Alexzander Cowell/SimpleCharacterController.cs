using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexzanderCowell
{
    // Variables to Start

    public class SimpleCharacterController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rBody2D;

        [Header("CharacterMovement")]
        [Range (1,50)]
        [SerializeField] private float walkSpeed; // Walk/run speed
        [Range(1, 50)]
        [SerializeField] private float jumpSpeed; // Jump speed

        [Header("CharacterSprite")]
        [SerializeField] private SpriteRenderer spriteRenderer; // choose your sprite
        public Animator animator; // animation reference

        [Header("CharacterVaribles")]
        private bool jump; // says yes or no when the player can jump

        private void Awake() {
            rBody2D = GetComponent<Rigidbody2D>(); // Physics for Character
        }

        void Update() {
            // Movement Controller

            transform.position += new Vector3(Input.GetAxis("Horizontal"), 0) * Time.deltaTime * walkSpeed;        
            if (Input.GetButtonDown("Horizontal")){
                animator.GetFloat("Speed");
                Debug.Log("Moving");
            }
            // Jump Controller Start every frame
           fixedupdate();
        }

        // Jump Controller
        void fixedupdate(){
            if (Input.GetButtonDown("Jump") && !jump){
               
               gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
                jump = true; Debug.Log("Jumping");
                animator.SetBool("IsJumping", true);


            }
        }

        private void OnCollisionEnter2D(Collision2D other){ // collides with the Ground tag it can jump. If not it will not jump.
            if (other.gameObject.CompareTag("Ground")){
                jump = false;
            }
            
        }




    }
    



}      


