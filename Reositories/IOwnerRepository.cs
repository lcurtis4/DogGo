using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Reositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
    }
}
