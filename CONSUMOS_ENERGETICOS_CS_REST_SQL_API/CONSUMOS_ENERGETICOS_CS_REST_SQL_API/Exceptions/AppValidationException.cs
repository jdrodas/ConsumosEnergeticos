﻿/*
AppValidationException:
Excepcion creada para enviar mensajes relacionados 
con la validación de datos en las capas de servicio
*/

namespace CONSUMOS_ENERGETICOS_CS_REST_SQL_API.Exceptions
{
    public class AppValidationException(string message) : Exception(message)
    {
    }
}