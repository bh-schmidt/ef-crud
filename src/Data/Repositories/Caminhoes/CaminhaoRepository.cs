﻿using Data.Context;
using Models.Caminhoes;

namespace Data.Repositories.Caminhoes
{
    public class CaminhaoRepository : Repository<Caminhao>, ICaminhaoRepository
    {
        public CaminhaoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
