//This is here for reference
public class SomeClassScript : MonoBehaviour {
  //This is the game object you want to access
  public GameObject target;
  //This is here for reference
  void Start() {
    target = GameObject.Find("Cube");
  }
}

// The shortcoming of this method is that it just returns the first item it finds with the given name. 
// If you have multiple Cube objects, you won’t know which one you are getting.

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

