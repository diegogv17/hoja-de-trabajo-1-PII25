using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoja_de_trabajo_1.hoja_de_trabajo
{
    /*Hecho por Jorge Omar Chután Rosales - 240070*/

    abstract class DocumentoFiscal
    {
        public string Numero { get; set; }

        public DocumentoFiscal(string numero)
        {
            Numero = numero;
        }

        public abstract void GenerarPDF();
    }

    // Subclase: Factura
    class Factura : DocumentoFiscal
    {
        public Factura(string numero) : base(numero) { }

        public override void GenerarPDF()
        {
            Console.WriteLine($"Generando PDF de Factura Nº {Numero}");
        }
    }

    // Subclase: Nota de Crédito
    class NotaCredito : DocumentoFiscal
    {
        public NotaCredito(string numero) : base(numero) { }

        public override void GenerarPDF()
        {
            Console.WriteLine($"Generando PDF de Nota de Crédito Nº {Numero}");
        }
    }

    // Subclase: Nota de Débito
    class NotaDebito : DocumentoFiscal
    {
        public NotaDebito(string numero) : base(numero) { }

        public override void GenerarPDF()
        {
            Console.WriteLine($"Generando PDF de Nota de Débito Nº {Numero}");
        }
    }

    // Clase que gestiona documentos
    class GestorDocumentos
    {
        private List<DocumentoFiscal> documentos;

        public GestorDocumentos(List<DocumentoFiscal> documentos)
        {
            this.documentos = documentos;
        }

        public void GenerarTodosLosPDFs()
        {
            foreach (var doc in documentos)
            {
                doc.GenerarPDF(); // Polimorfismo en acción
            }
        }
    }

    // Clase principal (Main)
    class Program
    {
        static void Main(string[] args)
        {
            var documentos = new List<DocumentoFiscal>
        {
            new Factura("F001-000123"),
            new NotaCredito("NC001-000045"),
            new NotaDebito("ND001-000078")
        };

            var gestor = new GestorDocumentos(documentos);
            gestor.GenerarTodosLosPDFs();

            Console.ReadKey();
        }
    }
}
