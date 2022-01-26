using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game
{
    public class Fps : MonoBehaviour
    {
        [SerializeField] private float sensi = 0.5f;
        [SerializeField] protected float vit = 2f;
        [SerializeField] private Munition munition = default;
        private float yawn = 0.0f;
        private float pitch = 0.0f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Cam();
            Deplacement();
            Shoot();
        }


        private void Cam()
        {
            yawn += Input.GetAxis("Mouse X") * sensi;
            pitch -= Input.GetAxis("Mouse Y") * sensi;
            pitch = Mathf.Clamp(pitch, -90f, 90f);

            transform.eulerAngles = new Vector3(pitch, yawn, 0f);
        }
        private void Deplacement()
        {
            Vector3 Pos = transform.position;
            Vector3 deltaPosition = (transform.right * Input.GetAxis("Horizontal")
                + transform.forward * Input.GetAxis("Vertical")) * vit;
            deltaPosition.y = 0f;
            transform.position = Pos + deltaPosition;
        }
        private void Shoot()
        {
            if (Input.GetButtonUp("Fire1"))
            { munition.Spawner_de_munition(); }
        }

    }
}