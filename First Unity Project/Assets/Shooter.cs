using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour
{
	RaycastHit hit;
    DuckHealth health;

    public AudioClip shot;
    public AudioSource source;
    private float volMin = .5f;
    private float volMax = 1f;

    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;


    private int bulletAmount;
	public int maxBullets;

	// Use this for initialization
	void Start ()
	{
        maxBullets = 3;
        bulletAmount = 50;
        GameManager.OnSpawnDucks += ResetBullets;
    }
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0))
		{
			bulletAmount--;
            BulletGUI(bulletAmount);
            float vol = Random.Range(volMin, volMax);
            source.PlayOneShot(shot, vol);

            if (bulletAmount <= 0)
			{
				GameManager.OnDuckMiss();
			}

			Vector3 mousePos = Input.mousePosition;
			mousePos.z = Camera.main.transform.position.z;

			if (Physics.Raycast (Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, out hit, Mathf.Infinity))
			{
                if (hit.transform.tag == "Duck")
                {
                    health = hit.transform.GetComponent<DuckHealth>();
                    health.KillDuck();
                    Debug.Log("Duck Shot!");
                }
                else
                    Debug.Log("Miss");
			}
		}
	}

	public void ResetBullets()
	{
		bulletAmount = maxBullets;
        bullet3.SetActive(true);
        bullet2.SetActive(true);
        bullet1.SetActive(true);
    }

    public void BulletGUI(int bullets)
    {
        if (bullets == 2)
        {
            bullet3.SetActive(false);
        }
        else if (bullets == 1)
        {
            bullet3.SetActive(false); bullet2.SetActive(false);
        }
        else if (bullets <= 0)
        {
            bullet3.SetActive(false); bullet2.SetActive(false); bullet1.SetActive(false);
        }
        else
        {
            bullet3.SetActive(true); bullet2.SetActive(true); bullet1.SetActive(true);
        }

    }
}
