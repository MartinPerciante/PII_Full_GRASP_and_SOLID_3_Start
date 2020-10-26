//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

//Se elimina la clase AllInOnePrinter y se reemplaza por una interface IPrinter para cumplir con LSP.
//Es necesario que las dos clases tanto de file como console implemente el mismo metodo para poder realizar la sustitucion (Polimorfismo)
//En la clase AllInOnePrinter se preguntaba con un IF el destino para saber a donde direccionar la impresion, 
//  eso es totalmente erroneo por lo cual se quitó dicho metodo.

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void Print(Recipe recipe);
    }
}