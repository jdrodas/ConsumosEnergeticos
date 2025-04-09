﻿namespace CONSUMOS_ENERGETICOS_CS_REST_NoSQL_API.Models
{
    public class ConsumosEnergeticosDatabaseSettings
    {
        public string DatabaseName { get; set; } = null!;
        public string ColeccionConsumos { get; set; } = null!;
        public string ColeccionComponentes { get; set; } = null!;
        public string ColeccionServicios { get; set; } = null!;
        public string ColeccionPeriodos { get; set; } = null!;

        public ConsumosEnergeticosDatabaseSettings(IConfiguration unaConfiguracion)
        {
            var configuracion = unaConfiguracion.GetSection("ConsumosEnergeticosDatabaseSettings");

            DatabaseName = configuracion.GetSection("DatabaseName").Value!;
            ColeccionConsumos = configuracion.GetSection("ColeccionConsumos").Value!;
            ColeccionComponentes = configuracion.GetSection("ColeccionComponentes").Value!;
            ColeccionServicios = configuracion.GetSection("ColeccionServicios").Value!;
            ColeccionPeriodos = configuracion.GetSection("ColeccionPeriodos").Value!;
        }
    }
}