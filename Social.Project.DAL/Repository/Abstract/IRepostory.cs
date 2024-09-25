using ClassLıbrary1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Project.DAL.Repository.Abstract;


public interface IRepository<T> where T : BaseEntity, new()
{
    public void Add(T entity);
    public void Update(int Id);
    public void Delete(int Id);
    public T GetById(int Id);
    public ICollection<T> GetAll();
    public void SaveChanges();

}
