/*

For instance, if you want to modify the preceding code to write the name of the
object that enters the trigger to the console, you could write the following

*/

void OnTriggerEnter(Collider other)
{
print(other.gameObject.name + " has entered the trigger");
}

/*
You could even go so far as to destroy the object entering the trigger with some code like this:
*/

void OnTriggerEnter(Collider other)
{
Destroy(other.gameObject);
}
