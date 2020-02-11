using System;

namespace Models.Caminhoes
{
    public class Caminhao : BaseModel
    {
        public ModeloCaminhao Modelo { get; set; }
        public string? NomeModelo => Enum.GetName(typeof(ModeloCaminhao), Modelo);
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
    }
}
