﻿using CONSUMOS_ENERGETICOS_CS_REST_SQL_API.Exceptions;
using CONSUMOS_ENERGETICOS_CS_REST_SQL_API.Interfaces;
using CONSUMOS_ENERGETICOS_CS_REST_SQL_API.Models;
using CONSUMOS_ENERGETICOS_CS_REST_SQL_API.Repositories;

namespace CONSUMOS_ENERGETICOS_CS_REST_SQL_API.Services
{
    public class ComponenteService(IComponenteRepository componenteRepository)
    {
        private readonly IComponenteRepository _componenteRepository = componenteRepository;

        public async Task<List<Componente>> GetAllAsync()
        {
            return await _componenteRepository
                .GetAllAsync();
        }

        public async Task<Componente> GetByGuidAsync(Guid componente_id)
        {
            Componente unComponente = await _componenteRepository
                .GetByGuidAsync(componente_id);

            if (unComponente.Id == Guid.Empty)
                throw new AppValidationException($"Componente no encontrado con el Guid {componente_id}");

            return unComponente;
        }
    }
}
