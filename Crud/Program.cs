using Microsoft.EntityFrameworkCore;
using ProjetoCrud.Context;
using ProjetoCrud.Entitie;

ClienteContext _context = new ClienteContext();

// ------------ Create ------------
Cliente novoCliente = new Cliente();

novoCliente.Nome = "José";
novoCliente.Email = "José.j@José.com.br";
novoCliente.Telefone = "19999999999";

_context.Add(novoCliente);
_context.SaveChanges();

// //------------ Read ------------
//  var clientes = _context.Clientes.ToList();

// foreach (var cliente in clientes)
// {
//     Console.WriteLine($"ID :{cliente.ID}, Nome :{cliente.Nome}, Email : {cliente.Email}, Telafone : {cliente.Telefone} \n");
// }

// //------------ Alter ------------
// var cliente = _context.Clientes.Where(c => c.ID == 1).FirstOrDefault();

// cliente.Nome = "José";
// cliente.Email = "jose.j@jose.com.br";

// _context.SaveChanges();

// //------------ Delete ------------
var cliente = _context.Clientes.Where(c => c.ID == 1).FirstOrDefault();

_context.Clientes.Remove(cliente);
_context.SaveChanges();

