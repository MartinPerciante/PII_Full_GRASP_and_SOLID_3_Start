using System;
using System.IO;

//Se crea una Clase FilePrinter (por SRP solo sabe imprimir por archivo). Tambien es necesaria para poder cumplir con LSP

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void Print(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }

    }

}