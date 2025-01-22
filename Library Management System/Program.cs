using Library_Management_System;


public class Program
{
    public static void Main(string[] args)
    {
        LibraryManager libraryManager = LibraryManager.Instance;

        libraryManager.HandleUserInput();
    }
}
