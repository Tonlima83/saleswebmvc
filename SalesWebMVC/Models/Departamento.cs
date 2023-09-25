using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models {
    public class Departamento {
        public int Id { get; set; }
        public string Nome { get; set;}
        public ICollection<Vendedor> vendedores { get; set; } = new List<Vendedor>();
        public Departamento() {
        }

        public Departamento(int id, string nome) {
            Id = id;
            Nome = nome;
        }
        public void AddVendedor(Vendedor vendedor) {
            vendedores.Add(vendedor);
        }
        public void RemoveVendedor(Vendedor vendedor) {
            vendedores.Remove(vendedor);
        }
        public double TotalVendas(DateTime inicial, DateTime final) {
            return vendedores.Sum(vendedor => vendedor.TotalVendas(inicial, final));
        }
    }
    
}
