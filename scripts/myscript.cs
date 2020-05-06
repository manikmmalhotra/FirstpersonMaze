using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class myscript : MonoBehaviour
{
    public FixedJoystick MoveJoystick;
    public fixedtouchpad Touchfield;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();

        fps.RunAxis = MoveJoystick.Direction;
        fps.mouseLook.LookAxis = Touchfield.TouchDist;
        
    }

   private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "win")
        {
            Invoke("winer", 1.5f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "dead")
        {
            Invoke("loser", 1f);
        }

    }

    private void winer()
    {
        SceneManager.LoadScene(0);
    }

    private void loser()
    {
        SceneManager.LoadScene(1);
    }
}
