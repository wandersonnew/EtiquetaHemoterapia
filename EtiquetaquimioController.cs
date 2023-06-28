using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ImpressaoZebra
{
    internal class EtiquetaquimioController
    {
        public List<string> dados = new List<string>();
        public List<string> BuscaDados(string matricula)
        {
            string oradb = "Data Source=ip-do-servidor:porta/orcl;User Id=usuario;Password=senha;";

            using (OracleConnection conn = new OracleConnection(oradb))
            {
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = @"SELECT
	                        P.NM_PACIENTE NOME
                            ,P.NM_MAE MAE
                            ,P.CD_PACIENTE MATRICULA
                            ,TO_CHAR(P.DT_NASCIMENTO, 'DD/MM/YYYY') NASCIMENTO
                        FROM DBAMV.PACIENTE P
                        WHERE P.CD_PACIENTE = :matricula";
                        cmd.Parameters.Add("matricula", matricula);
                        cmd.CommandType = CommandType.Text;
                        OracleDataReader dr = cmd.ExecuteReader();
                        // dr.Read();

                        if (dr.Read())
                        {
                            dados.Add(dr.GetString(0));
                            dados.Add(dr.GetString(1));
                            dados.Add(dr.GetString(2));
                            dados.Add(dr.GetString(3));
                        }
                        conn.Dispose();
                        conn.Close();
                        return dados;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ocorreu um erro: " + e.Message);
                        return null;
                    }
                }
            }
        }

        public void ImprimirDados(List<string> dados, string impressora)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings = new PrinterSettings();
            pd.PrinterSettings.PrinterName = impressora;
            pd.PrintPage += new PrintPageEventHandler((sender, ev) => PrintPage(sender, ev, dados));
            pd.DefaultPageSettings.Margins = new Margins(1, 1, 1, 1);
            pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 1100, 300);
            pd.Print();
        }

        private void PrintPage(object sender, PrintPageEventArgs ev, List<string> dados)
        {
            Font fonte = new Font("Arial", 9);
            Font fonteNegrito = new Font("Arial", 9, FontStyle.Bold);
            SolidBrush pincel = new SolidBrush(Color.Black);
            float lineHeight = fonte.GetHeight(ev.Graphics);
            Pen blackPen = new Pen(Color.Black, 1);

            // Create points that define line.
            PointF point1 = new PointF(1.0F, 65.0F);
            PointF point2 = new PointF(500.0F, 65.0F);
            PointF point3 = new PointF(1.0F, 210.0F);
            PointF point4 = new PointF(500.0F, 210.0F);

            // Draw line to screen.
            // Carregar a imagem
            Image logo = Image.FromFile("logo.png");

            // Definir as dimensões da imagem
            int width = 50; // largura desejada da imagem
            int height = 50; // altura desejada da imagem

            // Calcular as coordenadas de destino para o desenho da imagem
            // float x = ev.MarginBounds.Left;
            // float y = ev.MarginBounds.Top;
            float x = 40;
            float y = 10;

            // Desenhar a imagem nas coordenadas de destino especificadas
            ev.Graphics.DrawImage(logo, x, y, width, height);

            // ev.Graphics.DrawString("Santa Casa de Misericórdia de Sobral\nRua Antônio Crisóstomo de Melo, 919\nCNPJ:07.818.313/0001-09", fonte, pincel, 100, 10, new StringFormat());
            ev.Graphics.DrawString("Santa Casa de Misericórdia de Sobral", fonteNegrito, pincel, 100, 10, new StringFormat());
            ev.Graphics.DrawString("Rua Antônio Crisóstomo de Melo, 919\nCNPJ:07.818.313/0001-09", fonte, pincel, 100, 25, new StringFormat());
            ev.Graphics.DrawLine(blackPen, point1, point2);

            /*foreach (string dado in dados)
            {
                ev.Graphics.DrawString(dado, fonte, pincel, 40, yPos, new StringFormat());
                yPos += lineHeight;
            }*/
            
            ev.Graphics.DrawString("NOME: " + dados[0], fonte, pincel, 30, 80, new StringFormat());
            ev.Graphics.DrawString("MÃE: " + dados[1], fonte, pincel, 30, 95, new StringFormat());
            ev.Graphics.DrawString("MATRICULA: " + dados[2], fonte, pincel, 30, 110, new StringFormat());
            ev.Graphics.DrawString("NASCIMENTO: " + dados[3], fonte, pincel, 210, 110, new StringFormat());
            ev.Graphics.DrawString("SOLUÇÃO: " + dados[9], fonte, pincel, 30, 125, new StringFormat());
            ev.Graphics.DrawString("COMPOSIÇÃO: " + dados[4], fonte, pincel, 30, 140, new StringFormat());
            ev.Graphics.DrawString("VAZÃO: " + dados[5], fonte, pincel, 30, 155, new StringFormat());
            ev.Graphics.DrawString("DATA: " + dados[6], fonte, pincel, 30, 170, new StringFormat());
            ev.Graphics.DrawString("HORA: " + dados[7], fonte, pincel, 210, 170, new StringFormat());
            ev.Graphics.DrawString("PROTOCOLO: " + dados[8], fonte, pincel, 30, 185, new StringFormat());

            ev.Graphics.DrawLine(blackPen, point3, point4);

            ev.Graphics.DrawString("CARIMBO: ", fonteNegrito, pincel, 30, 210, new StringFormat());

        }

    }
}
