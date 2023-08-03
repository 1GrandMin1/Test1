using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCube : MonoBehaviour
{
    [SerializeField] private float _moveSpeed=5f;
   
    private Vector3 moveDirection;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private Animator _animatorCube;
    [SerializeField] private Text _scoreSphere;
    private int scoreSphere;
    
    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _animatorCube = GetComponent<Animator>();
        
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S))
        {
            moveDirection.z = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
            _characterController.Move(moveDirection);

        }
        _scoreSphere.text = "x" + scoreSphere.ToString();


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != null)
        {
            
            if (other.CompareTag("Sphere"))
            {
                Material material = this.GetComponent<Renderer>().material;
                material.color = new Color(Random.value, Random.value, Random.value, 1);            
                _animatorCube.SetTrigger("Sphere");
                scoreSphere++;
            }
            


        }
    }
}
