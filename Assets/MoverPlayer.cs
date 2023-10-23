using UnityEngine;

public class MovimientoConTeclado : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento

    void Update()
    {
        // Obtén la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcula el desplazamiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical) * velocidad * Time.deltaTime;

        // Aplica el desplazamiento al objeto
        transform.Translate(movimiento);
    }
}

