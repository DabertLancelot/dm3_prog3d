using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game {
    public class Touch : MonoBehaviour
    {
        [SerializeField] private Material colormur = default;


        
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer == LayerMask.GetMask("Sharknado"))
            {
              colormur = other.GetComponent<Material>();

            }
    void Update()
            {
                RaycastHit hit;

                bool foundAwall = Physics.Raycast(
                new Ray(
                transform.position, transform.forward), out hit,
                Mathf.Infinity, LayerMask.GetMask("Sharknado"));
                Debug.DrawRay(transform.position, transform.forward * 1000, foundAwall ? Color.green : Color.red);
            }
        }
    }
}
