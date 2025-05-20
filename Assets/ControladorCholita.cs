using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCholita : MonoBehaviour
{
    [SerializeField] Animator elAnimador;
    [SerializeField] bool Caminando;
    [SerializeField] Rigidbody2D cuerpito;
    [SerializeField] float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        cuerpito = GetComponent<Rigidbody2d>();
    }

    // Update is called once per frame
    void Update()
    {
        float entradaJugador = Input.GetAxis("Horizontal")
        elAnimador.SetBool("caminata", Caminando);

        if (transform.localScale.x > 0 && entradaJugador < 0)
            transform.localScale = new Vector2(transform.localScale.x * -1f, transform.localScale.y);
        else if 
        
    }
}
