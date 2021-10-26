/*
The final way to find an object is by its tag. An object’s tag is much like its layer (which was covered
previously). The only different is semantics. The layer is used for broad categories of interaction,
whereas the tag is used for basic identification. You create tags using the Tag Manager (click Edit >
Project Settings > Tags). Figure 9.4 shows how to add a new tag to the Tag Manager.
Now that a tag is added to an object, you can find it using the FindWithTag method:
*/


public class SomeClassScript : MonoBehaviour {
//This is the game object you want to access
  public GameObject target;
  //This is here for reference
  void Start() {
    target = GameObject.FindWithTag("TargetCube");  // TargetCube is the tag given by you in the inspector
  }
}

/*
Modifying Object Components
Once you have a reference to another object, working with the components of that object is almost
100% exactly the same. The only difference is that now, instead of simply writing the component
name, you need to write the object variable and a period in front of it:
*/

//This accesses the local component, not what you want
transform.Translate(0, 0, 0);
//This accesses the target object, what you want
targetObject.transform.Translate(0, 0, 0);


//This is the game object you want to access
public GameObject target;
//This is here for reference
  void Start() {
    target = GameObject.Find("Cube");
  }
  
  void Update() {
    target.transform.Translate(.05f, 0f, 0f);
    target.transform.Rotate(0f, 0f, 1f);
    target.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
  }
}
