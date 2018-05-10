using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaixaMassiva
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
#if DEBUG
            userField.Text = "jglasser";
            passwordField.Text = "\"Meubebe\"*38";
#endif
        }
        public string baixaOS(int numeroOS, string serialInstalado, string tipo, string modelo, string tecnico, string data)
        {
            // Conecta no WKF
            ProductionLogisticWKF.WKFServiceClient client = new ProductionLogisticWKF.WKFServiceClient();

            // Cria autenticação do WKF
            ProductionLogisticWKF.Authentication auth = new ProductionLogisticWKF.Authentication();
            auth.UserName = userField.Text;
            auth.Password = passwordField.Text;

            // Define parametros da busca
            ProductionLogisticWKF.BuscaOS parametrosDaBusca = new ProductionLogisticWKF.BuscaOS();
            parametrosDaBusca.NumeroOS = numeroOS;

            // Consulta OS
            ProductionLogisticWKF.RetornoConsultaOS consultaOS = client.WSConsultaOS(auth, parametrosDaBusca, 1, 10);
            ProductionLogisticWKF.OrdemDeServico os = consultaOS.ListOS[0];

            var statusAtual = consultaOS.ListOS[0].Status;

            if (statusAtual == "NOVA")
            {
                os.Status = "RECEBIDA";
                try
                {
                    var result = client.WSAtualizaOS(auth, os);
                    return result;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        

            // Baixa OS
            os.Status = "BAIXADA";
            os.DataAtendimento = DateTime.Now;
            os.TerminalEntra.NumSerie = serialInstalado;
            os.TerminalEntra.Modelo = modelo;
            os.TerminalEntra.TipoEquipamento = tipo;

            if (!string.IsNullOrEmpty(data))
                os.DataAtendimento = DateTime.Parse(data);

            switch (tecnico)
            {
                case "AJUSTE DE ESTOQUE":
                    os.Tecnico.NomeTecnico = "AJUSTE DE ESTOQUE";
                    os.Tecnico.NumeroDoc = "12188527712";
                    break;
                case "TOMBAMENTO":
                    os.Tecnico.NomeTecnico = "TOMBAMENTO";
                    os.Tecnico.NumeroDoc = "111111111111";
                    break;
                case "COMERCIAL REDIRECT":
                    os.Tecnico.NomeTecnico = "COMERCIAL REDIRECT";
                    os.Tecnico.NumeroDoc = "1";
                    break;
                default:
                    break;
            }
            try
            {
                var result = client.WSAtualizaOS(auth, os);

                // Fecha conexão
                client.Close();

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao baixar a OS " + numeroOS + ". - Erro: " + ex.Message);
                return ex.Message;
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão apertado! Vamos baixar as OSs.");
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                int j = 0;
                int numeroOS = Convert.ToInt32(grid.Rows[i].Cells[j].Value?.ToString());
                j++;
                var serialInstalado = grid.Rows[i].Cells[j].Value?.ToString();
                j++;
                var tipo = grid.Rows[i].Cells[j].Value?.ToString();
                j++;
                var modelo = grid.Rows[i].Cells[j].Value?.ToString();
                j++;
                var tecnico = grid.Rows[i].Cells[j].Value?.ToString();
                j++;
                var data = grid.Rows[i].Cells[j].Value?.ToString();

                if (numeroOS != 0)
                {
                    var result = baixaOS(numeroOS, serialInstalado, tipo, modelo, tecnico, data);
                    j++;
                    grid.Rows[i].Cells[j].Value = result;
                }
            }
            MessageBox.Show("Operação finalizada.");
        }

        private void userField_TextChanged(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botaoColar_Click(object sender, EventArgs e)
        {
            grid.Rows[0].Cells[0].Selected = true;
            char[] rowSplitter = { '\r', '\n' };

            char[] columnSplitter = { '\t' };

            //get the text from clipboard
            IDataObject dataInClipboard = Clipboard.GetDataObject();

            string stringInClipboard = (string)dataInClipboard.GetData(DataFormats.Text);

            //split it into lines
            string[] rowsInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);

            //get the row and column of selected cell in grid
            int r = grid.SelectedCells[0].RowIndex;

            int c = grid.SelectedCells[0].ColumnIndex;

            //add rows into grid to fit clipboard lines
            if (grid.Rows.Count < (r + rowsInClipboard.Length))

            {
                grid.Rows.Add(r + rowsInClipboard.Length - grid.Rows.Count);
            }

            // loop through the lines, split them into cells and place the values in the corresponding cell.
            for (int iRow = 0; iRow < rowsInClipboard.Length; iRow++)
            {
                //split row into cell values
                string[] valuesInRow = rowsInClipboard[iRow].Split(columnSplitter);

                //cycle through cell values
                for (int iCol = 0; iCol < valuesInRow.Length; iCol++)
                {

                    //assign cell value, only if it within columns of the grid
                    if (grid.ColumnCount - 1 >= c + iCol)
                    {
                        grid.Rows[r + iRow].Cells[c + iCol].Value = valuesInRow[iCol];
                    }
                }
            }
        }
    private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void restart_Click(object sender, EventArgs e)
        {
            this.grid.Rows.Clear();
        }
    }
}
