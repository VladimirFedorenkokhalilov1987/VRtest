using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeItem : MonoBehaviour
{

    public float spinValue =90;
    public Material _thisMaterial;
    public AudioSource _thisAudio;
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*spinValue*Time.deltaTime);
    }

    public void OnPointerIn()
    {
        _renderer.material.SetColor("_Color", Color.blue);
    }

    public void OnPointerOut()
    {
        _renderer.material.SetColor("_Color", _thisMaterial.color);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            _thisAudio.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _thisAudio.Stop();
        }
    }
}
