using FerPROJ.Base.ASP.Base.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WON.Entities.DBContext;

namespace WON.Services.Repository {
    public class DataRepository<TEntity> : IDataRepository<TEntity> where TEntity : BaseEntityModel {

        private readonly EntitiesDbContext _dbContext;

        public DataRepository(EntitiesDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task DeleteToDBAsync(TEntity entity) {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveToDBAsync(TEntity entity) {
            if (entity == null) {
                return;
            }
            entity.Id = Guid.NewGuid();
            _dbContext.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateToDBAsync(TEntity entity) {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<TEntity?> GetById(Guid id) {
            var dbSet = _dbContext.Set<TEntity>();
            if (id == null || id == Guid.Empty) {
                return default;
            }
            return await dbSet.FirstOrDefaultAsync(c=>c.Id == id);
        }
    }
}
