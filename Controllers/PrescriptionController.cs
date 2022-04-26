using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repository_pattern_project.Dto;
using repository_pattern_project.Models;
using repository_pattern_project.Models.Data;

namespace repository_pattern_project.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionRepository _repository;
        private readonly IMapper _mapper;
        public PrescriptionController(IPrescriptionRepository iprescriptions,IMapper mapper)
        {
            _repository=iprescriptions;
            _mapper=mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<PrescriptionReadDto>> GetAll()
        {
            var prescriptions= _repository.GetAll();
            var prescriptionDto = _mapper.Map<IEnumerable<PrescriptionReadDto>>(prescriptions);
            if (prescriptions == null)
            {
                return NotFound();
            }
            return Ok(prescriptionDto);
        }
        [HttpGet("{id}", Name = "GetPrescriptionById")]
        public ActionResult<PrescriptionReadDto> GetPrescriptionById(int id)
        {
            var prescription = _repository.Get(id);
            if (prescription == null)
            {
                return BadRequest("Id not found");
            }
            return (_mapper.Map<PrescriptionReadDto>(prescription));
        }
        [HttpPost]
        public ActionResult<PrescriptionReadDto> CreatePrescription(PrescriptionCreateDto prescriptionCreate)
        {
            var prescriptionmodel = _mapper.Map<Prescription>(prescriptionCreate);
            //
            _repository.Create(prescriptionmodel);
            _repository.SaveChanges();

            var prescriptionReadDto = _mapper.Map<PrescriptionReadDto>(prescriptionmodel);

            return Ok(prescriptionReadDto);

            //return CreatedAtRoute(nameof(GetPrescriptionById),
            // new { Id = prescriptionReadDto.Id }, prescriptionReadDto);
        }





    }
}
