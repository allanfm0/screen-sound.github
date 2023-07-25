# Screen-Sound
### C-Sharp training at ALURA: Learn to program in C# with Object Orientation

- Types and Functions in C#:
    - Type variables of different types like string and int for storing different types of data;
    - Developing the custom menu displaying our application's options and creating a way in which the user can choose the action they want.
    - Conditional structures in C#, which make it possible for our program to execute different commands according to conditions set by user input.
- List and Loops in C#:
    - For and Foreach.
    - We instantiate and add elements to the list with special methods like .Add, and add songs to our application.
    - Use a very important and used data structure that are the lists.
- Dictionary and the evaluation of the bands:
    - Dictionary which is a collection of key-value pairs, where each key is unique and associated with a corresponding value. It's a useful data structure for storing related information that needs to be accessed based on a specific key.
    - Keys and values ​​can be of any type as long as the key is unique. To access the value of a given key-value pair, simply use the corresponding key.
    - We have developed a return method in C# that serves to return a specific value or object to the method caller.
- C#: Applying Object Orientation.
    - We developed a music template with the following attributes: name, artist, genre, duration and availability. We use the concept of classes and attributes to represent this information.
    - We create a new type of variable called Music and repeat the process of assigning values ​​to its attributes. Again, we use the Console.WriteLine command to display the second song's information in the console.
    - We assign a method called DisplayFichaTecnica() with void return. This method was created to display the song's technical sheet, that is, all information about the song is displayed on the console when we call this method.
- Access methods and properties:
    - We fixed a system vulnerability that allowed changing the value of an attribute, violating the application's business rule by creating reading and writing methods (get and set).
    - We create a property in C#, which is good programming practice because it allows you to encapsulate access to attributes of a class, providing control, validation, and the possibility of adding additional behaviors to accessing these attributes.
    - We changed the get method of a property in C# to add custom logic before returning the corresponding attribute value.
- Integrating classes and defining relationships:
    - We created a model for the album as a class, reinforcing the practice of keeping each class in its own file, and the methods AddMusic and DuracaoTotal were discussed, showing how to add and list the songs.
    - We created a list of songs as a private field of the class, modified AddMusica using the "Add" method of the list to add songs, modified the method DuracaoTotal using the "Sum" method of the list to calculate the total duration of the songs and tests were performed relating songs to the album.
    - We display the list of songs in the album, showing the name of each song, in addition to displaying the total duration of the album through the method DisplayMusicasFromAlbum.
- Band builder:
    - We created a new class called Banda which has 2 methods: one to add an album and another to display the band's discography.
    - We learned the importance of a constructor and developed one for the Banda class in a practical way, initializing its attributes or performing other necessary tasks before using the object.
    - We integrate all classes of our application: Music, Album and Band and define a relationship between them.
- Organizing the project:
    - We apply the ScreenSound.Models namespace to the Album, Band and Musica classes, separating their files in the Models folder.
    - We applied the Banda and Album classes in the Program.cs file, making our application more object-oriented. A highlight is the encapsulation of notes as part of a band, making the code cleaner and easier to maintain in the future.
- Assessment class:
    - visibility modified by the internal and public reserved words. Internal classes can only be seen inside a project. Public classes are seen by any project that references them.
    - A method does not access information from the objects of the class where it is declared, it can be indicated as static. Just use the static keyword in your signature. And to be invoked, we use the model Tipo.MetodoEstatico(). Examples of static methods that we've been using since the first courses: Console.WriteLine(), int.Parse(), Thread.Sleep(), Console.Clear(), among others.
- Common menu behaviors:
    -In inheritance, ancestor classes can have behaviors replaced or overridden by their descendants. To indicate this possibility, we declare the member in the ancestor as virtual, and in the descendant that is going to overwrite it, we mark the class member with override. If we still want to run the piece of code that's in the ancestor, we use the base keyword.
- Alternative to attach similarities:
    - Inheritance is not the only way to include behaviors and characteristics common to a type. Interfaces are lighter, more abstract types that can be used to ensure that different hierarchical types implement the same methods and properties.
    - Interfaces do not have concrete code and cannot be instantiated through new.
- using an open ia in the project:
    - ====================================================================================
        using ScreenSound;
        using ScreenSound. Menus;
        using ScreenSound. Modelos;
        using OpenAI_API;

        var client = new OpenAIAPI("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");
    - ====================================================================================

