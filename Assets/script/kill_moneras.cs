using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kill_moneras : MonoBehaviour
{
    // Start is called before the first frame update
    public static int diemTong = 0;
    public GameObject diemText;
    public GameObject gameoverButton;
    public GameObject gameoverText;
    void Start()
    {
        CongDiem(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CongDiem(int diemcong)
   {
        diemTong += diemcong;
       diemText.GetComponent<Text>().text = "Diem:" + diemTong.ToString();
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        string name_monter = collision.attachedRigidbody.gameObject.name;
        if (collision.gameObject.tag == "ben_trai")
        {
           
            Destroy(GameObject.Find("2x_0"));
            gameoverButton.SetActive(true);
            gameoverText.SetActive(true);
            Time.timeScale = 0;

        }

         if (collision.gameObject.tag == "ben_tren")
       {
            CongDiem(5);
            Destroy(GameObject.Find(name_monter));
        }
        if (collision.gameObject.tag == "coinne")
        {
           
            CongDiem(1);
            Destroy(GameObject.Find(name_monter));


        }





    }
}
