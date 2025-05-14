using UnityEngine;

public class SampleUnityFunctions : MonoBehaviour
{
    Animator body;
    private void Awake()
    {
        //When you instantiate the class
        //The first function a script calls
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Used for setup after Awake
    }

    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //Used for physics and rigidbody
    }

    private void LateUpdate()
    {
        //Called after all the update functions currently running
        //Good for camera work
    }

    private void OnDestroy()
    {
        //Used to tidy any object references
    }
}
