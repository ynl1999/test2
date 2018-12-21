using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int  m_life = 3;
    public float m_speed = 1;
    public Transform m_rocket;
protected Transform m_plane;
    float m_rovketTimer = 0;
	// Use this for initialization
	void Start () {

        m_plane = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        float movev = 0;
        float moveh = 0;
       
        if(Input.GetKey(KeyCode.UpArrow))
        {
            movev-= m_speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            movev += m_speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveh += m_speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveh -= m_speed * Time.deltaTime;
        }
        m_rovketTimer -= Time.deltaTime;
        if (m_rovketTimer <= 0)
        {
            m_rovketTimer = 0.1f;
            if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
            {
                Instantiate(m_rocket, m_plane.position, m_plane.rotation);
            }
        }
        m_plane.Translate(new Vector3(moveh, 0, movev));
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.CompareTo("Enemy") == 0)
        {
            m_life -= 1;
            if (m_life <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
