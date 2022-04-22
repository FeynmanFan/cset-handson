using Checkpoints;
using System.Linq.Expressions;

var planets = new List<Planet>
{
    new Planet {Name = "Mercury", PlanetType = 0, StellarDistance = .39m},
    new Planet {Name = "Venus", PlanetType = 0, StellarDistance = .72m},
    new Planet {Name = "Earth", PlanetType = 0, StellarDistance = 1m},
    new Planet {Name = "Mars", PlanetType = 0, StellarDistance = 1.52m},
    new Planet {Name = "Jupiter", PlanetType = 0, StellarDistance = 5.2m},
    new Planet {Name = "Saturn", PlanetType = 0, StellarDistance = 9.54m},
    new Planet {Name = "Uranus", PlanetType = 0, StellarDistance = 19.2m},
    new Planet {Name = "Neptune", PlanetType = 0, StellarDistance = 30.06m}
};

var planetParam = Expression.Parameter(typeof(Planet), "planet");

var OneAU = Expression.Constant(1m);

var lessThan = Expression.LessThan(stellarDistance, OneAU);

var expr = Expression.Lambda<Func<Planet, bool>>(lessThan, false, planetParam);

var func = expr.Compile();

foreach(var planet in planets.Where(func))
{
    Console.WriteLine(planet.Name);
}

Console.WriteLine("End of line");