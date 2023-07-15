using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationRepository _workLocationRepository;

        public WorkLocationManager(IWorkLocationRepository workLocationRepository)
        {
            _workLocationRepository = workLocationRepository;
        }

        public void TAdd(WorkLocation t)
        {
            _workLocationRepository.Add(t);
        }

        public void TDelete(WorkLocation t)
        {
           _workLocationRepository.Delete(t);
        }

        public WorkLocation TGetByID(int id)
        {
           return _workLocationRepository.GetByID(id);  
        }

        public List<WorkLocation> TGetList()
        {
           return _workLocationRepository.GetList();
        }

        public void TUpdate(WorkLocation t)
        {
            _workLocationRepository.Update(t);
        }
    }
}
