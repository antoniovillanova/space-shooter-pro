using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
    [SerializeField]
    private int powerupID;

    void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.down);
        if(transform.position.y <= -5f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;

        var player = other.GetComponent<Player>();
        if (player != null)
        {
            switch (powerupID)
            {
                case 0:
                    player.TripleShotActive();
                    break;
                case 1:
                    player.SpeedBoostActive();
                    break;
                case 2:
                    player.ShieldActive();
                    break;
                default:
                    break;
            }
        }

        Destroy(this.gameObject);
    }
}
