using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltSpawner : MonoBehaviour {

    [Header("Settings")]
    public GameObject cubePrefab;
    public int cubeDensity;
    public int seed;
    public float innerRadius;
    public float outterRadius;
    public float height;
    public bool rotatingClockwise;

    [Header("Asteroid Settings")]
    public float minOrbitSpeed;
    public float maxOrbitSpeed;
    public float minRotationSpeed;
    public float maxRotationSpeed;

    public Vector3 localPosition;
    public Vector3 worldPosition;
    public Vector3 worldOffset;
    public float randomRadius;
    public float randomRadian;
    public float x;
    public float y;
    public float z;
    public GameObject textActive;

    int beltCreated;

    public void Update()
    {
        if (gameObject.GetComponent<MeshRenderer>().enabled && beltCreated == 0)
        {
            createBelt();
            textActive.SetActive(false);
            beltCreated = 1;
        }
    }

    public void createBelt()
    {
        Random.InitState(seed);
        for (int i = 0; i < cubeDensity; i++)
        {
            do
            {
                randomRadius = Random.Range(innerRadius, outterRadius);
                randomRadian = Random.Range(0, (2 * Mathf.PI));

                y = Random.Range(-(height / 2), (height / 2));
                x = randomRadius * Mathf.Cos(randomRadian);
                z = randomRadius * Mathf.Sin(randomRadian);
            }
            while (float.IsNaN(z) && float.IsNaN(x));
            localPosition = new Vector3(x, y, z);
            worldOffset = transform.rotation * localPosition;
            worldPosition = transform.position + worldOffset;

            GameObject asteroid = Instantiate(cubePrefab, worldPosition, Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            asteroid.AddComponent<BeltObject>().SetupBeltObject(Random.Range(minOrbitSpeed, maxOrbitSpeed), Random.Range(minRotationSpeed, maxRotationSpeed), gameObject, rotatingClockwise);
            asteroid.transform.SetParent(transform);
        }
    }
}
