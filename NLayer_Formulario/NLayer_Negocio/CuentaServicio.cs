﻿using NLayer_Datos;
using NLayer_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer_Negocio
{
    public class CuentaServicio
    {
        private CuentaMapper mapper;
        private ClienteServicio clienteServicio;

        public CuentaServicio()
        {
            mapper = new CuentaMapper();
            clienteServicio = new ClienteServicio();
        }

        public Cuenta Traer(int idCliente)
        {
            Cuenta result = mapper.Traer(idCliente);

            return result;
        }

        public Cuenta AbrirCuenta(string descripcion, int idCliente)
        {
            if (clienteServicio.Existe(idCliente))
            {
                Cuenta c = new Cuenta();
                c.IdCliente = idCliente;
                c.Descripcion = descripcion;

                TransactionResult t = mapper.Insert(c);

                if (t.IsOk)
                {
                    return Traer(idCliente);
                }
                else
                {
                    throw new Exception("Error al abrir cuenta" + t.Error);
                }
            }
            else
            {
                throw new Exception("El cliente no existe");
            }
        }

        public void ModificarSaldo(int idCuenta, float Saldo)
        {
            Cuenta c = new Cuenta();
            c.IdCliente = idCuenta;
            c.Saldo = Saldo;

            if (c.Saldo < 0)
            {
                throw new Exception("El saldo debe ser mayor a 0");
            }
            if (c.IdCliente <= 0)
            {
                throw new Exception("Debe ser un id de cuenta valido");
            }

            TransactionResult t = mapper.Update(c);
            if (!t.IsOk)
            {
                throw new Exception("Error al modificar el saldo de la cuenta");
            }
        }
    }
}
