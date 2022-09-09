using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _laserSpeed = 8.0f;

    void Update()
    {
        transform.Translate(_laserSpeed * Time.deltaTime * Vector3.up);

        if(transform.position.y > 8f)
        {
            if (transform.parent != null)
                Destroy(transform.parent.gameObject);
            Destroy(gameObject);
        }
    }
}
