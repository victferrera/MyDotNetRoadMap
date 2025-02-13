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
        // instance Equals() could be invoked on any instance except null
        // Object.ReferenceEquals() can be invoke using two nulls and will never throw a NullReferenceException
    }
}

class MyClass()
{
}
