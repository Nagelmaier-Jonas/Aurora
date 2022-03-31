using Domain.LogicHandlers.Exceptions;
using Model.Entities.OwnPattern;
using MudBlazor;

namespace Domain.LogicHandlers;

public static class ConvoyExtension {
    /*
     
    private async Task TryAddWagonAsync(int wagonIndex) {

        else if (_trucks[0].MaxContainer > _wagons.Count)
            _wagons.Add(VehicleFactory.Wagons[wagonIndex]);
        else {
            await DialogService.ShowMessageBox("Warning", "You have reached the maximum amount of wagons!");
            StateHasChanged();
        }
    }

    private async Task TryAddSetTruckAsync(int truckIndex) {
        if (_trucks[0] == null) {
            _trucks[0] = VehicleFactory.Trucks[truckIndex];
        }
        else if (_trucks[1] == null) {
            _trucks[1] = VehicleFactory.Trucks[truckIndex];
        }
        else {
            await DialogService.ShowMessageBox("Warning", "You have reached the maximum amount of trucks!");
            StateHasChanged();
        }
    }

    private void RemoveTruck(int index) {
        if (index == 0) {
            _wagons.Clear();
            _trucks[0] = null;
            _trucks[1] = null;
        }
        else
            _trucks[1] = null;
    }
    */

    public static void CanAddElement(this Convoy convoy) {
        if (!IsTruckPresent(convoy))
            throw new ConvoyManagementException("No truck present!");
    }

    public static bool IsTruckPresent(this Convoy convoy) =>
        convoy.Trucks[0] == null;
}