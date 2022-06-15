using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lktrangchu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void man_dau()
    {
        SceneManager.LoadScene("man1");
    }
    public void man_hai()
    {
        SceneManager.LoadScene("man2");
    }
    public void sos_sos()
    {
        SceneManager.LoadScene("trangchu");
    }
}
