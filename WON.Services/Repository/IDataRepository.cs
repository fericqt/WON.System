using FerPROJ.Base.ASP.Base.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WON.Services.Repository {
    public interface IDataRepository<TEntity> where TEntity : BaseEntityModel {
        Task SaveToDBAsync(TEntity entity);
        Task UpdateToDBAsync(TEntity entity);
        Task DeleteToDBAsync(TEntity entity);

    }
}
