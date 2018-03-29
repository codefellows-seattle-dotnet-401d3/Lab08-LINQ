# Lab08 Phil Werner

## LINQ
This program takes a JSON file and converts it to an object. Then utilizes
LINQ to do queries on the data. When the program runs it goes through a 
series of queries on neighborhoods of Manhattan. The first query is of all
the neighbors listed from the JSON, the second is of all neighborhoods that
are not ```null```, the third is of non ```null``` neighborhoods and those
that do not have blank names, the fourth is then just the unique neighborhoods.
The finally output is a query of everything at the same time, which ends up
just outputting the unique list of neighborhoods.

## Tools Used
Microsoft Visual Studio Community Version 15.5.7

C#

ASP.Net

xUnit

Newton Soft Json

## Getting Started

Clone this repository to your local machine.
```
$ git clone 
```
Once downloaded, cd into the ```Lab08-LINQ``` directory.
```
$ cd Lab08-LINQ
```
The cd into ```LINQManhattan``` directory.
```
$ cd LINQManhattan
```
The cd into the second ```LINQManhattan``` directory.
```
$ cd LINQManhattan
```
Then run .NET build.
```
$ dotnet build
```
Once that is complete, run the program.
```
$ dotnet run
```
## LINQ Examples
The Setup:

```
string manhattan;
using (StreamReader r = new StreamReader("data.json"))
{
	manhattan = r.ReadToEnd();
};
FeaturesCollection items = JsonConvert.DeserializeObject<FeaturesCollection>(manhattan);
```
The Long way:

```
var sampleNeighborhoods = from n in items.Features
						  where n.Properties.Neighborhood != null
                          select n;

```
The Short Way:

```
var sampleNeighborhoods = items.Features.Where(x => x.Properties.Neighborhood != null)
```

