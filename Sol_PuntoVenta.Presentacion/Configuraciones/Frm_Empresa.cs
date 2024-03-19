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

namespace Sol_PuntoVenta.Presentacion.Configuraciones
{
    public partial class Frm_Empresa : Form
    {
        public Frm_Empresa()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo_em = 0;
        int nCodigo_tdn = 0;
        int nCodigo_di = 0;
        int EstadoGuarda = 0;
        #endregion

        #region "Mis Métodos"
        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[1].Width = 98;
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO EM";
            Dgv_Listado.Columns[2].Width = 100;
            Dgv_Listado.Columns[2].HeaderText = "TIPO DOC.";
            Dgv_Listado.Columns[3].Width = 120;
            Dgv_Listado.Columns[3].HeaderText = "NRO.DOC.";
            Dgv_Listado.Columns[4].Width = 300;
            Dgv_Listado.Columns[4].HeaderText = "EMPRESA";
            Dgv_Listado.Columns[5].Width = 300;
            Dgv_Listado.Columns[5].HeaderText = "EMAIL";
            Dgv_Listado.Columns[6].Visible = false;
            Dgv_Listado.Columns[7].Visible = false;
            Dgv_Listado.Columns[8].Visible = false;
            Dgv_Listado.Columns[9].Visible = false;
            Dgv_Listado.Columns[10].Visible = false;
            Dgv_Listado.Columns[11].Visible = false;
        }

        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Empresa.Mostrar_em(Ctexto);
                this.Formato();
                Lbl_total.Text = "Total registros: " + Convert.ToString(Dgv_Listado.Rows.Count);
                Dgv_Listado.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_em"].Value)))
            {
                MessageBox.Show("Seleccione un registro ",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_em = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_em"].Value);
                Cmb_TipoDoc.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_tdn"].Value);
                nCodigo_tdn = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_tdn"].Value);
                Txt_nrodocumento_em.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["nrodocumento_em"].Value);
                Txt_razonsocial_em.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["razonsocial_em"].Value);
                Txt_email_em.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["email_em"].Value);
                Txt_descripcion_di.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["distrito"].Value);
                nCodigo_di = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_di"].Value);
                Txt_direccion_em.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["direccion_em"].Value);
                Txt_telefono_em.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["telefono_em"].Value);
                Txt_movil_em.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["movil_em"].Value);
            }
        }

        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;

            Txt_buscar.Clear();
            Txt_nrodocumento_em.Text = "";
            Txt_razonsocial_em.Text = "";
            Txt_email_em.Text = "";
            Txt_direccion_em.Text = "";
            Txt_telefono_em.Text = "";
            Txt_movil_em.Text = "";
            Cmb_TipoDoc.Enabled = Lestado;
            Txt_nrodocumento_em.ReadOnly = !Lestado;
            Txt_razonsocial_em.ReadOnly = !Lestado;
            Txt_email_em.ReadOnly = !Lestado;
            Txt_direccion_em.ReadOnly = !Lestado;
            Txt_telefono_em.ReadOnly = !Lestado;
            Txt_movil_em.ReadOnly = !Lestado;
        }

        private void Estado_BotonesPrincipales(bool Lestado)
        {
            Btn_nuevo.Enabled = Lestado;
            Btn_actualizar.Enabled = Lestado;
            Btn_eliminar.Enabled = Lestado;
            Btn_reporte.Enabled = Lestado;
            Btn_salir.Enabled = Lestado;
            btn_lupa4.Visible = !Lestado;

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

        private void Listar_tdn(string Ctexto)
        {
            try
            {
                Cmb_TipoDoc.DataSource = N_Empresa.Listar_tdn("%");
                Cmb_TipoDoc.ValueMember = "codigo_tdn";
                Cmb_TipoDoc.DisplayMember = "descripcion_tdn";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato_di()
        {
            Dgv_Listado_di.Columns[0].Width = 400;
            Dgv_Listado_di.Columns[0].HeaderText = "DISTRITO";
            Dgv_Listado_di.Columns[1].Visible = false;
        }

        private void Listar_di(string Ctexto)
        {
            try
            {
                Dgv_Listado_di.DataSource = N_Empresa.Listar_di(Ctexto);
                this.Formato_di();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_di()
        {
            nCodigo_di = Convert.ToInt32(Dgv_Listado_di.CurrentRow.Cells["codigo_di"].Value);
            Txt_descripcion_di.Text = Convert.ToString(Dgv_Listado_di.CurrentRow.Cells["distrito"].Value);
        }
        #endregion
        private void Frm_Empresa_Load(object sender, EventArgs e)
        {
            this.Listar_tdn("%");
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
                if (Cmb_TipoDoc.Text == string.Empty ||
                    Txt_nrodocumento_em.Text == string.Empty ||
                    Txt_razonsocial_em.Text == string.Empty ||
                    Txt_descripcion_di.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nCodigo_tdn = Convert.ToInt32(Cmb_TipoDoc.SelectedValue);
                    E_Empresa oPro = new E_Empresa();
                    string Cduplica, Rpta = "";
                    oPro.Codigo_em = nCodigo_em;
                    oPro.Codigo_tdn = nCodigo_tdn;
                    oPro.Nrodocumento_em = Txt_nrodocumento_em.Text.Trim();
                    oPro.Razonsocial_emp = Txt_razonsocial_em.Text.Trim();
                    oPro.Email_em = Txt_email_em.Text.Trim();
                    oPro.Codigo_di = nCodigo_di;
                    oPro.Direccion_em = Txt_direccion_em.Text.Trim();
                    oPro.Telefono_em = Txt_telefono_em.Text.Trim();
                    oPro.Movil_em = Txt_movil_em.Text.Trim();

                    // Verificamos si la información que se intenta guardar ya existe en la tabla
                    Cduplica = N_Empresa.Verifica_duplicado_em(this.EstadoGuarda, oPro.Codigo_em, oPro.Razonsocial_emp);
                    if (Cduplica == "")
                    {
                        Rpta = N_Empresa.Guardar_em(this.EstadoGuarda, oPro);
                        if (Rpta.Equals("OK"))
                        {
                            MessageBox.Show("Los datos han sido guardados correctamente",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Estado_Limpiar(false);
                            this.EstadoGuarda = 0;
                            nCodigo_em = 0;
                            nCodigo_tdn = 0;
                            nCodigo_di = 0;
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
            Tbp_general.SelectedIndex = 1;
            Txt_nrodocumento_em.Select();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            this.EstadoGuarda = 0;
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
                Txt_nrodocumento_em.Select();
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
                Opcion = MessageBox.Show("¿Estas seguro de eliminar los registros seleccionados?",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in Dgv_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = N_Empresa.Eliminar_em(Codigo);
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
            Frm_Rpt_Empresa oRpt_em = new Frm_Rpt_Empresa();
            oRpt_em.Txt_p1.Text = Txt_buscar.Text;
            oRpt_em.ShowDialog();
        }

        private void btn_lupa4_Click(object sender, EventArgs e)
        {
            Pnl_listado_di.Location = new Point(454, 17); ;
            Pnl_listado_di.Visible = true;
            Txt_buscar_di.Select();
            this.Listar_di(Txt_buscar_di.Text);
        }

        private void Btn_retornar_di_Click(object sender, EventArgs e)
        {
            Pnl_listado_di.Visible = false;
        }

        private void Btn_buscar_di_Click(object sender, EventArgs e)
        {
            this.Listar_di(Txt_buscar_di.Text);
        }

        private void Dgv_Listado_di_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_di();
            Pnl_listado_di.Visible = false;
            Txt_direccion_em.Select();
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
