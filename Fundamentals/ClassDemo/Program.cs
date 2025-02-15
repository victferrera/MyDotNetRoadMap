class Program
{
    static void Main()
    {
        // Creates an object of type MyClass.
        MyClass myObject = new MyClass();

        // Should return MyClass
        Console.WriteLine("myObject type: {0}", myObject.GetType());

        // Points to the same memory address
        // both objects has the same values, if one is updated the other one will be as well.
        MyClass mySecondObject = myObject;

        // Should return true
        Console.WriteLine("myObject is equal to mySecondObject? {0}", Object.ReferenceEquals(myObject, mySecondObject));

        // Should return false, since we have two distinct memory address
        MyClass myThirdObject = new MyClass();
        Console.WriteLine("mySecondObject is equal to myThirdObject? {0}", Object.ReferenceEquals(mySecondObject, myThirdObject));

        // About instance.Equals() and Object.ReferenceEquals()
        // instance Equals() could be invoked on any instance except null, can be overriden
        // Object.ReferenceEquals() can be invoke using two nulls and will never throw a NullReferenceException, can't be overriden

        // Creating an object without a reference
        // MyClass o3;

        // This comparisson will never work because it results in a compiler error when working with unassigned variables
        // C# compiler won't grant access to this variable until initialization is done
        // Object.ReferenceEquals(o3, null);

        // This one otherwise points to a null reference
        // this variable is explicity initialized
        MyClass o4 = null;

        Console.WriteLine("Object o4 is null? {0}", o4 is null); // returns true

        // But you can't do this, because will result in a NullReferenceException
        // when trying to access any member of the class which points to a null reference
        // o4.AnyMethod()
    }
}

class MyClass()
{
}
