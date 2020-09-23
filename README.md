# Harvest API Client for .NET Standard

[![NuGet Version](https://img.shields.io/nuget/v/Adafy.Harvest.Netstandard.svg?style=flat&label=Adafy.Harvest.Netstandard)](https://www.nuget.org/packages/Adafy.Harvest.Netstandard/)
 
This is a .NET Standard port of the [Harvest.Net](https://github.com/ithielnor/harvest.net).

Some parts of the code is from [lprichar/harvest.net](https://github.com/lprichar/harvest.net)

## Usage

Create a client object:

````
    HarvestRestClient client = new HarvestRestClient("example", "myusername", "mypassword");
````

Harvest API end points are converted to PascalCase. So `example.harvestapp.com/account/who_am_i` becomes

````
    Account myAccount = client.WhoAmI()
````	
	
## License

This library is MIT licensed.