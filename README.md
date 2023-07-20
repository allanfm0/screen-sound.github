﻿# Screen-Sound
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