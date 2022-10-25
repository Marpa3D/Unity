using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float _height;
    [SerializeField] private int _numberOfCoins;
    [SerializeField] private string _name;
    [SerializeField] private Color _bodyColor;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private bool _isAlive;

    [SerializeField] private Light _sunLight;
    [SerializeField] private Transform _ball;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1, _height, 1);
        gameObject.name = _name;
        gameObject.GetComponent<Renderer>().material.color = _bodyColor;
        transform.position = _startPosition;
        gameObject.SetActive(_isAlive);

        _sunLight.intensity = 4;
        _sunLight.color = _bodyColor;


    }

    // Update is called once per frame
    void Update()
    {
        _ball.position = transform.position + new Vector3(0, 4, 0);
    }
}
