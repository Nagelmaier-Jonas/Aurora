using Model.Entities.OwnPattern;
using NUnit.Framework;

namespace TestProject;

public class Tests {
    [SetUp]
    public void Setup() { }

    [Test]
    public void TruckAndAddonTest() {
        var truck = new Truck("Tobias", 10, 3, 3, 3);
        Assert.AreEqual(truck.Code, "Tobias");
        Assert.AreEqual(truck.Price, 10);
        Assert.AreEqual(truck.CargoList.Length, 3);
        Assert.AreEqual(truck.Speed, 3);
        Assert.AreEqual(truck.MaxContainer, 3);

        truck.Addon = new Addon("Tobi's Kriegsmaschine", 12, 3);

        Assert.AreEqual(truck.Addon.Code, "Tobi's Kriegsmaschine");
        Assert.AreEqual(truck.Addon.Price, 12);
        Assert.AreEqual(truck.Addon.CargoList.Length, 3);
    }

    [Test]
    public void VehicleFactoryTest() {
        var vehicle = VehicleFactory.CreateCzolgTesli();
        Assert.AreEqual(vehicle.Code, "Czolg Tesli");
        Assert.AreEqual(vehicle.Price, 10);
        Assert.AreEqual(vehicle.CargoList.Length, 4);
        Assert.AreEqual(vehicle.Speed, 3);
        Assert.AreEqual(vehicle.MaxContainer, 3);
    }

    [Test]
    public void WagonTest(){
        var wagon = new Wagon("Tobis Anhänger", 100, 3);
        Assert.AreEqual(wagon.Code, "Tobis Anhänger");
        Assert.AreEqual(wagon.Price, 100);
        Assert.AreEqual(wagon.CargoList.Length, 3);
    }
}