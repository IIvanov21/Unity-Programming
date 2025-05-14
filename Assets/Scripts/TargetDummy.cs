using UnityEngine;

public class TargetDummy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("TargetDummy spawned");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time * 2f) * 0.005f;
    }

    public void TakeDamage()
    {
        Destroy(gameObject);
    }
}
