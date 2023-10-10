namespace AppEmpresa.Data;
using System.Text.Json.Serialization;


public class Estudiante
    {
        [JsonPropertyName("id_estudiante")]
        public Int32 id_estudiante { get; set; }

        [JsonPropertyName("carne")]
        public string? carne { get; set; }

        [JsonPropertyName("nombres")]
        public string? Nombres { get; set; }
        [JsonPropertyName("apellidos")]
        public string? Apellidos { get; set; }
        [JsonPropertyName("direccion")]
        public string? Direccion { get; set; }
        [JsonPropertyName("telefono")]
        public string? Telefono { get; set; }

        [JsonPropertyName("correo_electronico")]
        public string? correo { get; set; }

        [JsonPropertyName("id_tipos_sangre")]
        public Int32 sangre { get; set; }

        [JsonPropertyName("fecha_nacimiento")]
        public DateTime? fecha_nacimiento { get; set; }

    }










