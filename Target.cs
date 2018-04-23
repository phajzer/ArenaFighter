using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        anim.Play("Death");
        Destroy(gameObject);
    }
}
