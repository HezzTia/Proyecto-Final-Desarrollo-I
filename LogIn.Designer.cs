namespace ProyectoFinal
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioLITxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClaveLITxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MostrarClaveBtn = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CrearCuentabtn = new System.Windows.Forms.Label();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(148, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar sesión";
            // 
            // UsuarioLITxt
            // 
            this.UsuarioLITxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioLITxt.Font = new System.Drawing.Font("Baskerville Old Face", 12F);
            this.UsuarioLITxt.Location = new System.Drawing.Point(76, 141);
            this.UsuarioLITxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsuarioLITxt.Name = "UsuarioLITxt";
            this.UsuarioLITxt.Size = new System.Drawing.Size(311, 23);
            this.UsuarioLITxt.TabIndex = 1;
            this.UsuarioLITxt.TextChanged += new System.EventHandler(this.UsuarioLITxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(72, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // ClaveLITxt
            // 
            this.ClaveLITxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClaveLITxt.Font = new System.Drawing.Font("Baskerville Old Face", 12F);
            this.ClaveLITxt.Location = new System.Drawing.Point(76, 217);
            this.ClaveLITxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClaveLITxt.Name = "ClaveLITxt";
            this.ClaveLITxt.PasswordChar = '*';
            this.ClaveLITxt.Size = new System.Drawing.Size(311, 23);
            this.ClaveLITxt.TabIndex = 3;
            this.ClaveLITxt.TextChanged += new System.EventHandler(this.ClaveLITxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(73, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // MostrarClaveBtn
            // 
            this.MostrarClaveBtn.AutoSize = true;
            this.MostrarClaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MostrarClaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostrarClaveBtn.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.MostrarClaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.MostrarClaveBtn.Location = new System.Drawing.Point(203, 274);
            this.MostrarClaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MostrarClaveBtn.Name = "MostrarClaveBtn";
            this.MostrarClaveBtn.Size = new System.Drawing.Size(172, 23);
            this.MostrarClaveBtn.TabIndex = 5;
            this.MostrarClaveBtn.Text = "Mostrar contraseña";
            this.MostrarClaveBtn.UseVisualStyleBackColor = true;
            this.MostrarClaveBtn.CheckedChanged += new System.EventHandler(this.MostrarClaveBtn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(224, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "O";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(150, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "No tienes una cuenta";
            // 
            // CrearCuentabtn
            // 
            this.CrearCuentabtn.AutoSize = true;
            this.CrearCuentabtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearCuentabtn.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.CrearCuentabtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.CrearCuentabtn.Location = new System.Drawing.Point(160, 405);
            this.CrearCuentabtn.Name = "CrearCuentabtn";
            this.CrearCuentabtn.Size = new System.Drawing.Size(139, 19);
            this.CrearCuentabtn.TabIndex = 9;
            this.CrearCuentabtn.Text = "Crear una cuenta";
            this.CrearCuentabtn.Click += new System.EventHandler(this.CrearCuenta_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = true;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Iniciar sesión";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges6;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeft = null;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRight = null;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleBorderRadius = 0;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(148, 319);
            this.bunifuButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 41;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(146)))));
            this.bunifuButton1.onHoverState.BorderRadius = 41;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(146)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(173)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 41;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 41;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(176, 41);
            this.bunifuButton1.TabIndex = 10;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(32, 26);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(52, 46);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(418, -1);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(52, 46);
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(467, 526);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.CrearCuentabtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MostrarClaveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClaveLITxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsuarioLITxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsuarioLITxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClaveLITxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox MostrarClaveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CrearCuentabtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
    }
}