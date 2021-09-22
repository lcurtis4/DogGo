using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DogGo.Models;
using DogGo.Reositories;

namespace DogGo.Controllers
{
   public class OwnerController : Controller
    {
        private readonly IOwnerRepository _ownerRepo;

        public OwnerController(IOwnerRepository ownerRepository)
        {
            _ownerRepo = ownerRepository;
        }

        public ActionResult Index()
        {
            List<Owner> owners = _ownerRepo.GetAllOwners();

            return View(owners);
        }

        public ActionResult Details(int id)
        {
            Owner owner = _ownerRepo.GetOwnerById(id);

            if (owner == null)
            {
                return NotFound();
            }

            return View(owner);
        }
    }
}
