using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;

namespace PizzariaDoZe.Infra.GerarPDF
{
    public abstract class GeradorPDF<T>
    {
        private string caminhoArquivo;
        protected List<T> listaObjetos;

        public GeradorPDF(string caminhoArquivo, List<T> objeto)
        {
            this.caminhoArquivo = caminhoArquivo;
            this.listaObjetos = objeto;
        }

        protected abstract void CriarImpressao(Document document);

        public void GerarPDF()
        {
            // Criação do documento PDF
            Document document = new Document();

            try
            {
                // Criação do escritor do PDF
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(caminhoArquivo, FileMode.Create));

                // Abre o documento para edição
                document.Open();

                CriarImpressao(document);
            }
            catch (DocumentException e)
            {
                Console.WriteLine("Erro ao criar PDF: " + e.Message);
            }
            finally
            {
                // Fecha o documento
                document.Close();
            }
        }
        
    }
}
