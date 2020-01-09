using UnityEngine;

public class RandomPowerup : MonoBehaviour
{
    /**attached to upgrade batch GameObjects. Simply put, this class randomly picks
     * a powerup in the batch, and enables it to be used in gameplay.**/
    public GameObject powerUp1;
    public GameObject powerUp2;
    public GameObject powerUp3;
    public GameObject powerUp4;

    void Start()
    {
        int random = Random.Range(1, 4);

        if (random == 1)
        {
            powerUp1.SetActive(true); //x2 size paddle upgrade
        }

        else if (random == 2)
        {
            powerUp2.SetActive(true); //slow down time upgrade
        }

        else if (random == 3)
        {
            powerUp3.SetActive(true); //life upgrade
        }

        else if (random == 4)
        {
            powerUp4.SetActive(true); //double paddle upgrade
        }
    }
}
