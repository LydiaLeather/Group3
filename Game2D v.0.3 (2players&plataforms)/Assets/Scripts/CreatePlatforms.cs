using UnityEngine;
using System.Collections;

public class CreatePlatforms : MonoBehaviour {
	public int maxPlatforms = 20;
	public GameObject platform;
	public float horizontalMin = 0f;
	public float horizontalMax = 6f;
	public float verticalMin = -2f;
	public float verticalMax = 2;

	private Vector2 originPosition;

	void Start() {
		originPosition = transform.position;
		CreatePlatf();
	}

	void CreatePlatf() {
		for (int i = 0; i < maxPlatforms; i++) {
			Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
			Instantiate(platform, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
		}
	}

}