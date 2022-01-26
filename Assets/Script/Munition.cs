using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace game
{
    public class Munition : MonoBehaviour
    {
        
        [SerializeField] private GameObject munitionPrefab = default;
        [SerializeField] private Transform munitionParent = default;
        [SerializeField] private float puissancedefeu = 1f;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        public void Spawner_de_munition()
        {
            GameObject munition_spawn =  Instantiate(
                munitionPrefab,
                transform.position, 
                Quaternion.identity, 
                munitionParent
                );

            munition_spawn.GetComponent<Rigidbody>().AddForce(transform.forward * puissancedefeu);
        }
    }


}