using AutoMapper;
using repository_pattern_project.Dto;
using repository_pattern_project.Models;

namespace repository_pattern_project.Profiles
{
    public class PrescriptionReadDtoProfile:Profile
    {

        public PrescriptionReadDtoProfile()
        {
            //source to destionation
            CreateMap<Prescription, PrescriptionReadDto>();
        }

    }
}
