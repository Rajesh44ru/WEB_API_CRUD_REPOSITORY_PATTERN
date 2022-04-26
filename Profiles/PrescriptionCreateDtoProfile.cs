using AutoMapper;
using repository_pattern_project.Dto;
using repository_pattern_project.Models;


namespace repository_pattern_project.Profiles
{
    public class PrescriptionCreateDtoProfile:Profile
    {
        public PrescriptionCreateDtoProfile()
        {


            CreateMap<PrescriptionCreateDto,Prescription>();
        }
    }
}
