using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody))]
public class AxeCutter : MonoBehaviour
{

    public Material capMaterial;

    // Use this for initialization

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {

        GameObject victim = collision.collider.gameObject;
        GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

        if (!pieces[1].GetComponent<Rigidbody>())
            pieces[1].AddComponent<Rigidbody>();

        Destroy(pieces[1], 1);
    }

}
