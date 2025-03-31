﻿using CONSUMOS_ENERGETICOS_CS_REST_SQL_API.Models;
using System.Security.Claims;

namespace CONSUMOS_ENERGETICOS_CS_REST_SQL_API.Interfaces
{
    public interface IServicioRepository
    {
        public Task<List<Servicio>> GetAllAsync();

        public Task<Servicio> GetByGuidAsync(Guid servicio_id);

        public Task<Servicio> GetByNameAsync(string servicio_nombre);

        public Task<List<Componente>> GetAssociatedComponentsAsync(Guid servicio_id);

        public Task<bool> CreateAsync(Servicio unServicio);


        //TODO: Crear el método para actualiza - Servicio
        //TODO: Crear el método para borrar - Servicio
    }
}
