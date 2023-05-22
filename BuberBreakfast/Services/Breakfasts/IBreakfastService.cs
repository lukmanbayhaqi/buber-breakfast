using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
  ErrorOr<Created> CreateBreakfast(Breakfast request);
  ErrorOr<Breakfast> GetBreakfast(Guid id);
  ErrorOr<UpsertedBreakfast> UpsertBreakfast(Breakfast breakfast);
  ErrorOr<Deleted> DeleteBreakfast(Guid id);
}