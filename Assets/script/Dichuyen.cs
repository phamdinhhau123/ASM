using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dichuyen : MonoBehaviour
{
    public Animator ani;
    public bool qua_man;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            ani.SetBool("inrunning", true);
            ani.Play("running");
            transform.Translate(Time.deltaTime * 3, 0, 0);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            ani.SetBool("inrunning", false);
            //ani.Play("running");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ani.SetBool("inrunning", true);
            ani.Play("running");
            transform.Translate(-Time.deltaTime * 3, 0, 0);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, Time.deltaTime * 10, 0);

        }
    }

        private void OnCollisionEnter2D(Collision2D colllision)
        
        {
            
            if (colllision.gameObject.tag == "qua_man")
            {
                SceneManager.LoadScene("man2");
            }
        


    }
}

