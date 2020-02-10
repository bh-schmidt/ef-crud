using System;

namespace Models.Caminhoes
{
    public class Caminhao : BaseModel
    {
        public ModeloCaminhao Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
    }
}
