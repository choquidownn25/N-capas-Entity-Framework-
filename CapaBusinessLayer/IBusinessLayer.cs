using CapaAccesoDatos.Repositorio;
using CapaDominioModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CapaBusinessLayer
{

    public interface IBusinessLayer
    {
        IList<Categoria> GetAllCategory();
        Categoria GetCategoryByName(string categoriaNombre);
        void AddCategory(params Categoria[] categorias);
        void UpdateeCategory(params Categoria[] categorias);
        void RemoveCategory(params Categoria[] categorias);

        IList<Pais> GetAllPais();
        void AddPais(Pais employee);
        void UpdatePais(Pais employee);
        void RemovePais(Pais employee);
    }

    public class BuinessLayer : IBusinessLayer
    {
        private readonly ICategoryRepository _ICategoryRepository;
        private readonly IPaisRepository _IPaisRepository;

        public BuinessLayer()
        {
            _ICategoryRepository = new CategoryRepository();
            _IPaisRepository = new PaisRepository();
        }

        void IBusinessLayer.AddCategory(params Categoria[] categorias)
        {
            throw new NotImplementedException();
        }

        void IBusinessLayer.AddPais(Pais employee)
        {
            throw new NotImplementedException();
        }

        IList<Categoria> IBusinessLayer.GetAllCategory()
        {
           return _ICategoryRepository.GetAll();
        }

        IList<Pais> IBusinessLayer.GetAllPais()
        {
            throw new NotImplementedException();
        }

        Categoria IBusinessLayer.GetCategoryByName(string categoriaNombre)
        {
            throw new NotImplementedException();
        }

        void IBusinessLayer.RemoveCategory(params Categoria[] categorias)
        {
            throw new NotImplementedException();
        }

        void IBusinessLayer.RemovePais(Pais employee)
        {
            throw new NotImplementedException();
        }

        void IBusinessLayer.UpdateeCategory(params Categoria[] categorias)
        {
            throw new NotImplementedException();
        }

        void IBusinessLayer.UpdatePais(Pais employee)
        {
            throw new NotImplementedException();
        }



        //public IList<Department> GetAllDepartments()
        //{
        //    return _deptRepository.GetAll();
        //}

        //public Department GetDepartmentByName(string departmentName)
        //{
        //    return _deptRepository.GetSingle(
        //        d => d.Name.Equals(departmentName),
        //        d => d.Employees); //include related employees
        //}

        //public void AddDepartment(params Department[] departments)
        //{
        //    /* Validation and error handling omitted */
        //    _deptRepository.Add(departments);
        //}

        //public void UpdateDepartment(params Department[] departments)
        //{
        //    /* Validation and error handling omitted */
        //    _deptRepository.Update(departments);
        //}

        //public void RemoveDepartment(params Department[] departments)
        //{
        //    /* Validation and error handling omitted */
        //    _deptRepository.Remove(departments);
        //}

        //public IList<Employee> GetEmployeesByDepartmentName(string departmentName)
        //{
        //    return _employeeRepository.GetList(e => e.Department.Name.Equals(departmentName));
        //}

        //public void AddEmployee(Employee employee)
        //{
        //    /* Validation and error handling omitted */
        //    _employeeRepository.Add(employee);
        //}

        //public void UpdateEmploee(Employee employee)
        //{
        //    /* Validation and error handling omitted */
        //    _employeeRepository.Update(employee);
        //}

        //public void RemoveEmployee(Employee employee)
        //{
        //    /* Validation and error handling omitted */
        //    _employeeRepository.Remove(employee);
        //}
    }

}
