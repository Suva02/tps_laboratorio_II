
namespace WinFormsApp1
{
    partial class frmEliminar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblReservaAEliminar = new System.Windows.Forms.Label();
            this.lblDatosEliminar = new System.Windows.Forms.Label();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.lblApellidoEliminar = new System.Windows.Forms.Label();
            this.lblDniEliminar = new System.Windows.Forms.Label();
            this.lblDireccionEliminar = new System.Windows.Forms.Label();
            this.lblTelefonoEliminar = new System.Windows.Forms.Label();
            this.lblVehiculoEliminar = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.txtApellidoEliminar = new System.Windows.Forms.TextBox();
            this.txtDniEliminar = new System.Windows.Forms.TextBox();
            this.txtDireccionEliminar = new System.Windows.Forms.TextBox();
            this.txtTelefonoEliminar = new System.Windows.Forms.TextBox();
            this.txtVehiculoEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lstEliminarReserva = new System.Windows.Forms.ListBox();
            this.btnMostrarReservas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReservaAEliminar
            // 
            this.lblReservaAEliminar.AutoSize = true;
            this.lblReservaAEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReservaAEliminar.Location = new System.Drawing.Point(525, 44);
            this.lblReservaAEliminar.Name = "lblReservaAEliminar";
            this.lblReservaAEliminar.Size = new System.Drawing.Size(218, 28);
            this.lblReservaAEliminar.TabIndex = 0;
            this.lblReservaAEliminar.Text = "RESERVA A ELIMINAR";
            // 
            // lblDatosEliminar
            // 
            this.lblDatosEliminar.AutoSize = true;
            this.lblDatosEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatosEliminar.Location = new System.Drawing.Point(57, 44);
            this.lblDatosEliminar.Name = "lblDatosEliminar";
            this.lblDatosEliminar.Size = new System.Drawing.Size(207, 28);
            this.lblDatosEliminar.TabIndex = 1;
            this.lblDatosEliminar.Text = "DATOS PERSONALES";
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.AutoSize = true;
            this.lblNombreEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreEliminar.Location = new System.Drawing.Point(61, 122);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(71, 20);
            this.lblNombreEliminar.TabIndex = 2;
            this.lblNombreEliminar.Text = "Nombre:";
            // 
            // lblApellidoEliminar
            // 
            this.lblApellidoEliminar.AutoSize = true;
            this.lblApellidoEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoEliminar.Location = new System.Drawing.Point(61, 167);
            this.lblApellidoEliminar.Name = "lblApellidoEliminar";
            this.lblApellidoEliminar.Size = new System.Drawing.Size(71, 20);
            this.lblApellidoEliminar.TabIndex = 3;
            this.lblApellidoEliminar.Text = "Apellido:";
            // 
            // lblDniEliminar
            // 
            this.lblDniEliminar.AutoSize = true;
            this.lblDniEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDniEliminar.Location = new System.Drawing.Point(61, 208);
            this.lblDniEliminar.Name = "lblDniEliminar";
            this.lblDniEliminar.Size = new System.Drawing.Size(37, 20);
            this.lblDniEliminar.TabIndex = 4;
            this.lblDniEliminar.Text = "Dni:";
            // 
            // lblDireccionEliminar
            // 
            this.lblDireccionEliminar.AutoSize = true;
            this.lblDireccionEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDireccionEliminar.Location = new System.Drawing.Point(61, 256);
            this.lblDireccionEliminar.Name = "lblDireccionEliminar";
            this.lblDireccionEliminar.Size = new System.Drawing.Size(78, 20);
            this.lblDireccionEliminar.TabIndex = 5;
            this.lblDireccionEliminar.Text = "Direccion:";
            // 
            // lblTelefonoEliminar
            // 
            this.lblTelefonoEliminar.AutoSize = true;
            this.lblTelefonoEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefonoEliminar.Location = new System.Drawing.Point(59, 297);
            this.lblTelefonoEliminar.Name = "lblTelefonoEliminar";
            this.lblTelefonoEliminar.Size = new System.Drawing.Size(74, 20);
            this.lblTelefonoEliminar.TabIndex = 6;
            this.lblTelefonoEliminar.Text = "Telefono:";
            // 
            // lblVehiculoEliminar
            // 
            this.lblVehiculoEliminar.AutoSize = true;
            this.lblVehiculoEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVehiculoEliminar.Location = new System.Drawing.Point(61, 341);
            this.lblVehiculoEliminar.Name = "lblVehiculoEliminar";
            this.lblVehiculoEliminar.Size = new System.Drawing.Size(72, 20);
            this.lblVehiculoEliminar.TabIndex = 7;
            this.lblVehiculoEliminar.Text = "Vehiculo:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.Location = new System.Drawing.Point(139, 119);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(125, 27);
            this.txtNombreEliminar.TabIndex = 9;
            // 
            // txtApellidoEliminar
            // 
            this.txtApellidoEliminar.Location = new System.Drawing.Point(139, 164);
            this.txtApellidoEliminar.Name = "txtApellidoEliminar";
            this.txtApellidoEliminar.Size = new System.Drawing.Size(125, 27);
            this.txtApellidoEliminar.TabIndex = 10;
            // 
            // txtDniEliminar
            // 
            this.txtDniEliminar.Location = new System.Drawing.Point(139, 205);
            this.txtDniEliminar.Name = "txtDniEliminar";
            this.txtDniEliminar.Size = new System.Drawing.Size(125, 27);
            this.txtDniEliminar.TabIndex = 11;
            // 
            // txtDireccionEliminar
            // 
            this.txtDireccionEliminar.Location = new System.Drawing.Point(139, 253);
            this.txtDireccionEliminar.Name = "txtDireccionEliminar";
            this.txtDireccionEliminar.Size = new System.Drawing.Size(125, 27);
            this.txtDireccionEliminar.TabIndex = 12;
            // 
            // txtTelefonoEliminar
            // 
            this.txtTelefonoEliminar.Location = new System.Drawing.Point(139, 294);
            this.txtTelefonoEliminar.Name = "txtTelefonoEliminar";
            this.txtTelefonoEliminar.Size = new System.Drawing.Size(125, 27);
            this.txtTelefonoEliminar.TabIndex = 13;
            // 
            // txtVehiculoEliminar
            // 
            this.txtVehiculoEliminar.Location = new System.Drawing.Point(139, 341);
            this.txtVehiculoEliminar.Name = "txtVehiculoEliminar";
            this.txtVehiculoEliminar.PlaceholderText = "A seleccionar (lista)";
            this.txtVehiculoEliminar.ReadOnly = true;
            this.txtVehiculoEliminar.Size = new System.Drawing.Size(144, 27);
            this.txtVehiculoEliminar.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(61, 405);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 33);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(170, 405);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(94, 33);
            this.btnAtras.TabIndex = 16;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lstEliminarReserva
            // 
            this.lstEliminarReserva.FormattingEnabled = true;
            this.lstEliminarReserva.ItemHeight = 20;
            this.lstEliminarReserva.Location = new System.Drawing.Point(504, 119);
            this.lstEliminarReserva.Name = "lstEliminarReserva";
            this.lstEliminarReserva.Size = new System.Drawing.Size(249, 244);
            this.lstEliminarReserva.TabIndex = 17;
            this.lstEliminarReserva.DoubleClick += new System.EventHandler(this.lstEliminarReserva_DoubleClick);
            // 
            // btnMostrarReservas
            // 
            this.btnMostrarReservas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarReservas.Location = new System.Drawing.Point(504, 405);
            this.btnMostrarReservas.Name = "btnMostrarReservas";
            this.btnMostrarReservas.Size = new System.Drawing.Size(142, 33);
            this.btnMostrarReservas.TabIndex = 18;
            this.btnMostrarReservas.Text = "Mostrar reservas";
            this.btnMostrarReservas.UseVisualStyleBackColor = true;
            this.btnMostrarReservas.Click += new System.EventHandler(this.btnMostrarReservas_Click);
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarReservas);
            this.Controls.Add(this.lstEliminarReserva);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtVehiculoEliminar);
            this.Controls.Add(this.txtTelefonoEliminar);
            this.Controls.Add(this.txtDireccionEliminar);
            this.Controls.Add(this.txtDniEliminar);
            this.Controls.Add(this.txtApellidoEliminar);
            this.Controls.Add(this.txtNombreEliminar);
            this.Controls.Add(this.lblVehiculoEliminar);
            this.Controls.Add(this.lblTelefonoEliminar);
            this.Controls.Add(this.lblDireccionEliminar);
            this.Controls.Add(this.lblDniEliminar);
            this.Controls.Add(this.lblApellidoEliminar);
            this.Controls.Add(this.lblNombreEliminar);
            this.Controls.Add(this.lblDatosEliminar);
            this.Controls.Add(this.lblReservaAEliminar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReservaAEliminar;
        private System.Windows.Forms.Label lblDatosEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.Label lblApellidoEliminar;
        private System.Windows.Forms.Label lblDniEliminar;
        private System.Windows.Forms.Label lblDireccionEliminar;
        private System.Windows.Forms.Label lblTelefonoEliminar;
        private System.Windows.Forms.Label lblVehiculoEliminar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.TextBox txtApellidoEliminar;
        private System.Windows.Forms.TextBox txtDniEliminar;
        private System.Windows.Forms.TextBox txtDireccionEliminar;
        private System.Windows.Forms.TextBox txtTelefonoEliminar;
        private System.Windows.Forms.TextBox txtVehiculoEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ListBox lstEliminarReserva;
        private System.Windows.Forms.Button btnMostrarReservas;
    }
}