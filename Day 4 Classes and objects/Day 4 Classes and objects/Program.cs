// See https://aka.ms/new-console-template for more information
using Day_4_Classes_and_objects;

Console.WriteLine("Hello, World!");

Movie firstMovie = new Movie();

firstMovie.MovieTitle= "The Flash";
firstMovie.MovieReleaseStatus = true;
firstMovie.MovieReleaseYear = 2023;

string firstmoviestuff = $"The name of the movie is {firstMovie.MovieTitle} and it is being released in {firstMovie.MovieReleaseYear} and the current status of releasing is{firstMovie.MovieReleaseStatus}";

Console.WriteLine(firstmoviestuff);

Movie secondMovie = new Movie();

secondMovie.MovieTitle = "Elemental";
secondMovie.MovieReleaseStatus = false;
secondMovie.MovieReleaseYear = 2023;

string secondmoviestuff = $"The name of the movie is {secondMovie.MovieTitle} and it is being released in {secondMovie.MovieReleaseYear} and the current status of releasing is{secondMovie.MovieReleaseStatus}";

Console.WriteLine(secondmoviestuff);

Movie thirdMovie = new Movie();

thirdMovie.MovieTitle = "Indiana Jones and the Dial of Destiny";
thirdMovie.MovieReleaseStatus = false;
thirdMovie.MovieReleaseYear = 2023;

string thirdmoviestuff = $"The name of the movie is {thirdMovie.MovieTitle} and it is being released in {thirdMovie.MovieReleaseYear} and the current status of releasing is{thirdMovie.MovieReleaseStatus}";

Console.WriteLine(thirdmoviestuff);



//Lets create a video game object with minecraft

VideoGames firstvideogame = new VideoGames();

firstvideogame.NameOfVideoGame = "Minecraft";
firstvideogame.TypeOfVideoGame = "Multiplayer sandbox";
firstvideogame.TypeOfGamingDevice = "Mobile, Console, PC";
firstvideogame.GameReleaseYear = 2011;

string firstvideogameoutput = $"name : {firstvideogame.NameOfVideoGame} type of videogame: {firstvideogame.TypeOfVideoGame} where can you play it: {firstvideogame.TypeOfGamingDevice} game release year: {firstvideogame.GameReleaseYear}";

Console.WriteLine(firstvideogameoutput);