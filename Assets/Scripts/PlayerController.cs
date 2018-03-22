using System;
using System.Runtime.Serialization;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    public float LookSpeed;

    [SerializeField] private GameController _gameController;

    private CharacterController _player;
    private PlayerInput _playerInput;

    public void Start()
    {
        _player = GetComponent<CharacterController>();
        _playerInput = GetComponent<PlayerInput>();
    }
    
    public void Update ()
    {
        transform.Rotate( _playerInput.Rotate * LookSpeed);
        _player.Move(transform.rotation * _playerInput.Move * MoveSpeed);
    }

}

