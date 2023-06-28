using iTextSharp.text;
using iTextSharp.text.pdf;
using PizzariaDoZe.Domain.FeaturePedido;
using PizzariaDoZe.Infra.GerarPDF;

namespace PizzariaDoZe.Infra.FeaturePedido
{
    public class GerarPDFPedido : GeradorPDF<Pedido>
    {
        public GerarPDFPedido(string caminhoArquivo, List<Pedido> objeto) : base(caminhoArquivo, objeto)
        {
        }
        protected override void CriarImpressao(Document document)
        {
            int interacao = 1;

            listaObjetos.ForEach(objeto =>
            {
                CriarTitulo(document, objeto);

                CriarTabela(document, objeto);

                if(interacao != listaObjetos.Count)
                    CriarLinhaCorte(document);

                interacao++;
            });
        }


        #region métodos privados
        private void CriarLinhaCorte(Document document)
        {
            Paragraph linhaCorte = new Paragraph(1);
            linhaCorte.SpacingBefore = 30;
            linhaCorte.SpacingAfter = 10;
            linhaCorte.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            linhaCorte.Add($"--------------------------------------------------------------------------");

            document.Add(linhaCorte);
        }

        private void CriarTabela(iTextSharp.text.Document document, Pedido objeto)
        {
            PdfPTable table = new PdfPTable(1);

            table.AddCell($"Funcionario: {objeto.Funcionario.ToString()}");

            AdicionarPizzas(table, objeto);

            AdicionarProdutos(table, objeto);

            table.AddCell($"Valor: {objeto.ValorTotal.ToString()}");
            
            document.Add(table);
        }

        private void AdicionarProdutos(PdfPTable table, Pedido objeto)
        {
            objeto.Produtos.ForEach(p =>
            {
                Paragraph tabelaProduto = new Paragraph(1);

                tabelaProduto.Add($"Produto:  {p.nome} | Valor: {p.valor} | Medida (ML): {p.medida_unitaria}");

                table.AddCell(tabelaProduto);
            });
        }

        private void AdicionarPizzas(PdfPTable table, Pedido objeto)
        {
            objeto.Pizzas.ForEach(p =>
            {
                Paragraph tabelaPizza = new Paragraph(1);
                tabelaPizza.Add($"Pizza {objeto.Pizzas.IndexOf(p) + 1} | Tamanho: {p.TamanhoPizza} | Borda: {p.TipoBorda} | Valor: {p.Valor}");

                p.sabores.ForEach(s =>
                {
                    PdfPTable tabelaSabor = new PdfPTable(3);

                    iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(ByteToImage(s.foto), System.Drawing.Imaging.ImageFormat.Jpeg);

                    tabelaSabor.AddCell($"Sabor: {s.nome}");

                    tabelaSabor.AddCell(pic);

                    tabelaSabor.AddCell($"Categoria: {s.categoria}");

                    tabelaPizza.Add(tabelaSabor);
                });

                table.AddCell(tabelaPizza);
            });
        }

        protected void CriarTitulo(iTextSharp.text.Document documento, Pedido objeto)
        {
            var titulo = $"Pedido: {objeto.Id} | Cliente: {objeto.Cliente.nome} | Data: {objeto.dataPedido.ToString("dd-MM-yyyy")}";
            Paragraph paragraph = new Paragraph(titulo, new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
            paragraph.Alignment = Element.ALIGN_CENTER;
            documento.Add(paragraph);
            documento.Add(Chunk.NEWLINE);
        }

        private System.Drawing.Image ByteToImage(byte[] bityImage)
        {
            using (var ms = new MemoryStream(bityImage))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
        #endregion
    }
}
