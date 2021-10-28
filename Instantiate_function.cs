Instantiate(GameObject prefab);

/*
As you can see, this method simply reads in a game object variable and makes a new object of it. The
location, rotation, and scale of the new object are the same as the prefab in the Project view. The
second way to use the Instantiate() method is like this:
*/

Instantiate(GameObject prefab, Vector3 position, Quaternion rotation);

/*

This method requires three parameters. The first is still the object to make a copyof. The second and
third parameters are the desired position and rotation of the new object. You might have noticed that
the rotation is stored in something called a Quaternion. Just know that this is how Unity stores rotation
information. The true application of the Quaternion is beyond the scope of this hour.

*/
