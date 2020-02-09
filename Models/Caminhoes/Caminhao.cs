using System;

namespace Models.Caminhoes
{
    public class Caminhao : BaseModel
    {
        public ModeloCaminhao Modelo { get; set; }
        public short AnoFabricacao { get; set; }
        public short AnoModelo { get; set; }
    }
}
