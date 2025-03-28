﻿using CONSUMOS_ENERGETICOS_CS_REST_SQL_API.Exceptions;
using CONSUMOS_ENERGETICOS_CS_REST_SQL_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CONSUMOS_ENERGETICOS_CS_REST_SQL_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController(ServicioService servicioService) : Controller
    {
        private readonly ServicioService _servicioService = servicioService;

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var losServicios = await _servicioService
                .GetAllAsync();

            return Ok(losServicios);
        }

        [HttpGet("{servicio_id:Guid}")]
        public async Task<IActionResult> GetByGuidAsync(Guid servicio_id)
        {
            try
            {
                var unServicio = await _servicioService
                    .GetByGuidAsync(servicio_id);

                return Ok(unServicio);
            }
            catch (AppValidationException error)
            {
                return NotFound(error.Message);
            }
        }

        [HttpGet("{servicio_id:Guid}/Componentes")]
        public async Task<IActionResult> GetAssociatedComponentsAsync(Guid servicio_id)
        {
            try
            {
                var losComponentesAsociados = await _servicioService
                    .GetAssociatedComponentsAsync(servicio_id);

                return Ok(losComponentesAsociados);
            }
            catch (AppValidationException error)
            {
                return NotFound(error.Message);
            }
        }

        //TODO: Crear el método para mapear el HTTP - POST - Servicio
        //TODO: Crear el método para mapear el HTTP - PUT - Servicio
        //TODO: Crear el método para mapear el HTTP - DEL - Servicio
    }
}
