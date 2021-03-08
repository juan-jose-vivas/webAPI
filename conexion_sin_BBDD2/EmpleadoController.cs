using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace web_api_core_ServicioAPI2.Models
{
    [Route("api/[controller]")]
    public class EmpleadoController : Controller
    {


        List<Empleado> listapersonas = new List<Empleado>();

        public EmpleadoController()
        {
            Empleado e = new Empleado { EMPNO = 7839, APELLIDO = "REY", OFICIO = "PRESIDENTE", DIR = 11, FECHA_ALTA=new DateTime(1995,11,17) , SALARIO=20000 , COMISION=10, DEPT_NO=34 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7698, APELLIDO = "SANCHEZ", OFICIO = "DIRECTOR", DIR = 12, FECHA_ALTA = new DateTime(1996, 12, 18), SALARIO = 30000, COMISION = 11, DEPT_NO = 35 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7566, APELLIDO = "NEGRO", OFICIO = "VENDEDOR", DIR = 13, FECHA_ALTA = new DateTime(1997, 1, 19), SALARIO = 40000, COMISION = 12, DEPT_NO = 36 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7782, APELLIDO = "JIMENEZ", OFICIO = "ANALISTA", DIR = 14, FECHA_ALTA = new DateTime(1998, 2, 20), SALARIO = 50000, COMISION = 13, DEPT_NO = 34 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7499, APELLIDO = "CEREZO", OFICIO = "EMPLEADO", DIR = 15, FECHA_ALTA = new DateTime(1999, 3, 21), SALARIO = 60000, COMISION = 14, DEPT_NO = 34 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7521, APELLIDO = "ARROYO", OFICIO = "EMPLEADO", DIR = 16, FECHA_ALTA = new DateTime(2000, 4, 22), SALARIO = 70000, COMISION = 15, DEPT_NO = 34 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7654, APELLIDO = "SALA", OFICIO = "ANALISTA", DIR = 17, FECHA_ALTA = new DateTime(2001, 5, 23), SALARIO = 80000, COMISION = 16, DEPT_NO = 34 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7844, APELLIDO = "MARTIN", OFICIO = "VENDEDOR", DIR = 18, FECHA_ALTA = new DateTime(2002, 6, 24), SALARIO = 25000, COMISION = 17, DEPT_NO = 34 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7900, APELLIDO = "TOVAR", OFICIO = "ANALISTA", DIR = 19, FECHA_ALTA = new DateTime(2003, 7, 25), SALARIO = 26000, COMISION = 18, DEPT_NO = 34 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7902, APELLIDO = "JIMENO", OFICIO = "EMPLEADO", DIR = 20, FECHA_ALTA = new DateTime(2004, 8, 26), SALARIO = 27000, COMISION = 19, DEPT_NO = 34 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7788, APELLIDO = "FERNANDEZ", OFICIO = "ANALISTA", DIR = 31, FECHA_ALTA = new DateTime(2005, 9, 27), SALARIO = 28000, COMISION = 21, DEPT_NO = 34 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7369, APELLIDO = "GIL", OFICIO = "VENDEDOR", DIR = 32, FECHA_ALTA = new DateTime(1996, 10, 28), SALARIO = 29000, COMISION = 22, DEPT_NO = 34 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7876, APELLIDO = "ALONSO", OFICIO = "VENDEDOR", DIR = 33, FECHA_ALTA = new DateTime(1995, 11, 29), SALARIO = 37000, COMISION = 23, DEPT_NO = 34 };
            this.listapersonas.Add(e);
            e = new Empleado { EMPNO = 7934, APELLIDO = "MUÑOZ", OFICIO = "PLEADO", DIR = 34, FECHA_ALTA = new DateTime(1994, 12, 30), SALARIO = 38000, COMISION = 24, DEPT_NO = 34 };
            this.listapersonas.Add(e);


        }






        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
