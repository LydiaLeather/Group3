using UnityEngine;
using System.Collections;

public class CreatePlatforms : MonoBehaviour {
	int maxPlatforms = 50;
	public GameObject platform;
    public GameObject coin;
    float horizontalMin;
    float horizontalMax;
    float verticalMin;
    float verticalMax;

	private Vector2 originPosition;

	void Start() {
        //originPosition = transform.position;
		CreatePlatf();
	}

	void CreatePlatf() {
        GameObject initPlatform = GameObject.Find("Grass");
        horizontalMin = initPlatform.GetComponent<Renderer>().bounds.size.x;
        horizontalMax = 1.3f * horizontalMin;
        verticalMin = 3;
        verticalMax = 6;
        originPosition = initPlatform.transform.position;
        for (int i = 0; i < maxPlatforms; i++) {
			Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            GameObject newPlatform = Instantiate(platform, randomPosition, Quaternion.identity);
            for (int j = 0; j < 3; j++)
            {
                coin = Instantiate(coin, originPosition + new Vector2(randomPosition.x + j * 2, randomPosition.y + 3), Quaternion.identity);
                coin.tag = "Coin";
            }

            originPosition = randomPosition;
		}
	}


}