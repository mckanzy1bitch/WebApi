using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LR_WEB_API.Controllers
{
    [Route("api/warehouses")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public WarehouseController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult GetWarehouse()
        {
            
                var warehouses = _repository.Warehouse.GetAllWarehouse(trackChanges:false);
                var warehousesDto = _mapper.Map<IEnumerable<WarehouseDto>>(warehouses);
                return Ok(warehousesDto);
           
        }

        [HttpGet("{id}")]
        public IActionResult GetWarehouse(Guid id)
        {
            var warehouse = _repository.Warehouse.GetWarehouse(id, trackChanges: false);
            if (warehouse == null)
            {
                _logger.LogInfo($"Warehouse with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var warehouseDto = _mapper.Map<WarehouseDto>(warehouse);
                return Ok(warehouseDto);
            }
        }
    }
}
