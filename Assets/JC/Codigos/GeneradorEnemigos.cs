using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
	[SerializeField]
	private GameObject enemigo01;
	[SerializeField]
	private float iniciarTiempo;
	[SerializeField]
	private float repetirTiempo;
	private int contador=0;
	[SerializeField]
	private int maximoEnemigos=5;
	[SerializeField]
	private float distanciaEnemigos=1.5f;
	
	private int enemigosXLinea=1;
	[SerializeField]
	private int maximoEnemigosXLinea=3;
	
	private int lineas=1;
	[SerializeField]
	private int cantidadHaciaFrente=3;
	[SerializeField]
	
	private int lineasTotales=5;
	
	//[SerializeField]
	//private float extencionCampoBatalla=4.6f;
	
    // Start is called before the first frame update
    void Start()
    {
		InvokeRepeating("GenerarEnemigo", iniciarTiempo, repetirTiempo);
	}
	
		
        
    public void GenerarEnemigo()
	{
		if(contador<maximoEnemigos)
		{
					Instantiate(enemigo01, transform.position,transform.rotation);
						for(int i=0;i<=lineasTotales;i++)
						{
							if(enemigosXLinea==maximoEnemigosXLinea*i)
							{
								if(lineas<cantidadHaciaFrente&&lineas<=lineasTotales)
								{
									transform.Translate(0f,0f,distanciaEnemigos);
									lineas++;
								} else
								{
									transform.Translate(0f,0f,distanciaEnemigos*(-1));
									lineas++;
								}
							}
						}
		enemigosXLinea++;
		contador++;
		}
	}
}
