using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile_1;
    [SerializeField] GameObject projectile_2;
    [SerializeField] GameObject projectile_3;
    [SerializeField] GameObject projectile_4;
    [SerializeField] GameObject projectile_5;
    [SerializeField] GameObject projectile_6;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectile_1.SetActive(true);
            projectile_2.SetActive(true);
            projectile_3.SetActive(true);
            projectile_4.SetActive(true);
            projectile_5.SetActive(true);
            projectile_6.SetActive(true);
            Destroy(gameObject);
        }
    }

}
