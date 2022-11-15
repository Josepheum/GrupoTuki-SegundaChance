using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GeneradorAutos : MonoBehaviour
{
	[SerializeField]
    private GameObject[] modelosAutos;
    
    private void Start()
    {
		Instantiate(ElegirModelo(), transform);
	}
	
	private GameObject ElegirModelo()
	{
		var indiceAleatorio = Random.Range(0, modelosAutos.Length);
		return modelosAutos[indiceAleatorio];
	}
}
