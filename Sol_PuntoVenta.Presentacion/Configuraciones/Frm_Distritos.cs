using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_PuntoVenta.Negocio;
using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Presentacion.Configuraciones.Reportes;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Distritos : Form
    {
        public Frm_Distritos()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int Codigo_di = 0;
        int Codigo_po = 0;
        int EstadoGuarda = 0;
        #endregion

        #region "Mis Métodos"
        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[1].Width = 100;
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO DI";
            Dgv_Listado.Columns[2].Width = 300;
            Dgv_Listado.Columns[2].HeaderText = "DEPARTAMENTO";
            Dgv_Listado.Columns[3].Width = 300;
            Dgv_Listado.Columns[3].HeaderText = "PROVINCIA";
            Dgv_Listado.Columns[4].Width = 300;
            Dgv_Listado.Columns[4].HeaderText = "DISTRITO";
            Dgv_Listado.Columns[5].Visible = false;
        }

        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Distritos.Mostrar_di(Ctexto);
                this.Formato();
                Lbl_total.Text = "Total registros: " + Convert.ToString(Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_di"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Codigo_di = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_di"].Value);
                Txt_descripcion_po.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_pr"].Value) + " - " + Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_fa"].Value);
                Codigo_po = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_pr"].Value);
                Txt_descripcion_di.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_di"].Value);
            }
        }

        private void Formato_po()
        {
            Dgv_Listado_po.Columns[0].Width = 280;
            Dgv_Listado_po.Columns[0].HeaderText = "DEPARTAMENTO";
            Dgv_Listado_po.Columns[1].Width = 280;
            Dgv_Listado_po.Columns[1].HeaderText = "PROVINCIA";
            Dgv_Listado_po.Columns[2].Visible = false;
        }

        private void Listar_po(string Ctexto)
        {
            try
            {
                Dgv_Listado_po.DataSource = N_Distritos.Listar_po(Ctexto);
                this.Formato_po();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_po()
        {
            Codigo_po = Convert.ToInt32(Dgv_Listado_po.CurrentRow.Cells["codigo_po"].Value);
            Txt_descripcion_po.Text = Convert.ToString(Dgv_Listado_po.CurrentRow.Cells["descripcion_po"].Value) + " - " + Convert.ToString(Dgv_Listado_po.CurrentRow.Cells["descripcion_fa"].Value);
        }
        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;

            Txt_buscar.Clear();
            Txt_descripcion_di.Clear();
            Txt_descripcion_di.ReadOnly = !Lestado;
            Pnl_listado_po.Visible = false;
        }

        private void Estado_BotonesPrincipales(bool Lestado)
        {
            Btn_nuevo.Enabled = Lestado;
            Btn_actualizar.Enabled = Lestado;
            Btn_eliminar.Enabled = Lestado;
            Btn_reporte.Enabled = Lestado;
            Btn_salir.Enabled = Lestado;
            btn_lupa.Visible = !Lestado;

            if (this.EstadoGuarda > 0)
            {
                Dgv_Listado.Enabled = Lestado;
            }
            else
            {
                Dgv_Listado.Enabled = true;
            }
            Txt_buscar.Enabled = Lestado;
            Btn_buscar.Enabled = Lestado;
        }
        #endregion

        private void Frm_Distritos_Load(object sender, EventArgs e)
        {
            this.Mostrar("%");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Mostrar(Txt_buscar.Text);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_descripcion_di.Text == string.Empty ||
                    Txt_descripcion_po.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    E_Distritos oPro = new E_Distritos();
                    string Cduplica, Rpta = "";
                    oPro.Codigo_di = Codigo_di;
                    oPro.Codigo_pr = Codigo_po;
                    oPro.Descripcion_di = Txt_descripcion_di.Text.Trim();
                    
                    // Verificamos si la información que se intenta guardar ya existe en la tabla
                    Cduplica = N_Distritos.Verifica_duplicado_di(this.EstadoGuarda, oPro.Codigo_di, oPro.Descripcion_di);
                    if (Cduplica == "")
                    {
                        Rpta = N_Distritos.Guardar_di(this.EstadoGuarda, oPro);
                        if (Rpta.Equals("OK"))
                        {
                            MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Estado_Limpiar(false);
                            Codigo_di = 0;
                            this.EstadoGuarda = 0;
                            this.Mostrar("%");
                            Tbp_general.SelectedIndex = 0;
                            this.Estado_BotonesPrincipales(true);
                        }
                        else
                        {
                            MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los datos que se intenta guardar ya existe en la base de datos con el código: " + Cduplica, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.EstadoGuarda = 1; //Nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Limpiar(true);
            Codigo_di = 0;
            Tbp_general.SelectedIndex = 1;
            Txt_descripcion_di.Select();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            this.EstadoGuarda = 0;
            Codigo_di = 0;
            Tbp_general.SelectedIndex = 0;
            this.Estado_BotonesPrincipales(true);
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (this.Dgv_Listado.Rows.Count > 0)
            {
                this.EstadoGuarda = 2; //Actualizar registro
                this.Estado_BotonesPrincipales(false);
                this.Estado_Limpiar(true);
                this.Selecciona_dgv();
                Tbp_general.SelectedIndex = 1;
                Txt_descripcion_di.Select();
            }

        }

        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Estado_Limpiar(false);
            this.Selecciona_dgv();
            Tbp_general.SelectedIndex = 1;
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            this.EstadoGuarda = 0;
            Tbp_general.SelectedIndex = 0;
            this.Estado_BotonesPrincipales(true);
        }

        private void Dgv_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Listado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)Dgv_Listado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }

        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estas seguro de eliminar los registros seleccionados?", "Aviso del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in Dgv_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = N_Distritos.Eliminar_di(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                // por definir que mensaje ubicar
                            }
                            else
                            {
                                MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    this.Mostrar("%");
                    Btn_cancelar2.Visible = false;
                    Btn_confirmar.Visible = false;
                    this.Estado_BotonesPrincipales(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                this.Estado_BotonesPrincipales(false);
                Dgv_Listado.Columns[0].Visible = true;
                Btn_cancelar2.Visible = true;
                Btn_confirmar.Visible = true;
                Tbp_general.SelectedIndex = 0;
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Frm_Rpt_Distritos ORpt_di = new Frm_Rpt_Distritos();
            ORpt_di.Txt_p1.Text = Txt_buscar.Text;
            ORpt_di.ShowDialog();
        }

        private void btn_lupa_Click(object sender, EventArgs e)
        {
            Pnl_listado_po.Visible = true;
            Txt_buscar_po.Select();
            this.Listar_po(Txt_buscar_po.Text);
        }

        private void Btn_retornar_po_Click(object sender, EventArgs e)
        {
            Pnl_listado_po.Visible = false;
        }

        private void Btn_buscar_po_Click(object sender, EventArgs e)
        {
            this.Listar_po(Txt_buscar_po.Text);
        }

        private void Dgv_Listado_po_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_po();
            Pnl_listado_po.Visible = false;
        }

        private void Btn_cancelar2_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesPrincipales(true);
            Dgv_Listado.Columns[0].Visible = false;
            foreach (DataGridViewRow row in Dgv_Listado.Rows)
            {
                row.Cells["Seleccionar"].Value = false;
            }
            Btn_cancelar2.Visible = false;
            Btn_confirmar.Visible = false;
        }
    }
}
