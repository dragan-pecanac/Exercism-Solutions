/*
Task 1: Define the Lasagna.ExpectedMinutesInOven() method that does not take any parameters and returns how many minutes the lasagna should be in the oven. 
According to the cooking book, the expected oven time in minutes is 40:

var lasagna = new Lasagna();
lasagna.ExpectedMinutesInOven();
// => 40
*/

class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

/*Define the Lasagna.RemainingMinutesInOven() method that takes the actual min. the lasagna has been in oven as parameter and returns how many min. 
lasagna still has to remain in oven, based on the expected oven time in min. from previous task
var lasagna = new Lasagna();
lasagna.RemainingMinutesInOven(30);
// => 10
*/

public int RemainingMinutesInOven(int MinutesInOven) => ExpectedMinutesInOven() - MinutesInOven;

/*Define the Lasagna.PreparationTimeInMinutes() method that takes the number of layers you added to the lasagna as a parameter and returns how many min. 
you spent preparing the lasagna, assuming each layer takes you 2 min. to prepare
var lasagna = new Lasagna();
lasagna.PreparationTimeInMinutes(2);
// => 4
*/

public int PreparationTimeInMinutes(int NumberOfLayers) => NumberOfLayers * 2;

/*Define the Lasagna.ElapsedTimeInMinutes() method that takes two parameters: the first parameter is number of layers you added to lasagna, and second parameter 
is number of min. lasagna has been in oven. The function should return how many min. you've worked on cooking lasagna, the sum of the prep time in min. 
and time in min. the lasagna has spent in oven
var lasagna = new Lasagna();
lasagna.ElapsedTimeInMinutes(3, 20);
// => 26
*/

public int ElapsedTimeInMinutes(int NumberOfLayers, int MinutesInOven) => PreparationTimeInMinutes(NumberOfLayers) + MinutesInOven;
}
