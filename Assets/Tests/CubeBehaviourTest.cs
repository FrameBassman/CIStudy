using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CubeBehaviourTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void CubeBehaviourTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CubeBehaviourTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
    
    [UnityTest]
    public IEnumerator CubeChangesColorOnHit()
    {
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<BoxCollider>();
        gameObject.AddComponent<MeshRenderer>().material = new Material(Shader.Find("Standard"));
        
        CubeBehaviour cube = gameObject.AddComponent<CubeBehaviour>();
        cube.transform.position = Vector3.up * 3;

        GameObject planeObject = new GameObject();
        planeObject.transform.localScale = new Vector3(5, 1, 5);
        planeObject.AddComponent<BoxCollider>();

        yield return new WaitForSeconds(4f);
        
        Assert.AreEqual(Color.blue, cube.CurColor);
    }
}
