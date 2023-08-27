using System.Drawing;

namespace Authorization_registration_menu
{
    partial class SignIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eye = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bSignIn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bSignUp = new System.Windows.Forms.PictureBox();
            this.lSignUp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.Color.White;
            this.tbLogin.Location = new System.Drawing.Point(54, 13);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(247, 23);
            this.tbLogin.TabIndex = 6;
            this.tbLogin.Text = "Login";
            this.tbLogin.Enter += new System.EventHandler(this.tbLogin_Enter);
            this.tbLogin.Leave += new System.EventHandler(this.tbLogin_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(220)))), ((int)(((byte)(203)))));
            this.label2.Font = new System.Drawing.Font("Helvetica Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(645, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 48);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hello, friend!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(606, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(220)))), ((int)(((byte)(203)))));
            this.label3.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(661, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Your personal details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(220)))), ((int)(((byte)(203)))));
            this.label4.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(673, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "and start journey with us";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Helvetica Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(91, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 48);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sign in to life tracker";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.tbLogin);
            this.panel1.Location = new System.Drawing.Point(135, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 47);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.panel2.Controls.Add(this.eye);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Location = new System.Drawing.Point(135, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 47);
            this.panel2.TabIndex = 17;
            // 
            // eye
            // 
            this.eye.Image = ((System.Drawing.Image)(resources.GetObject("eye.Image")));
            this.eye.Location = new System.Drawing.Point(282, 9);
            this.eye.Name = "eye";
            this.eye.Size = new System.Drawing.Size(30, 30);
            this.eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eye.TabIndex = 18;
            this.eye.TabStop = false;
            this.eye.Click += new System.EventHandler(this.eye_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(54, 13);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(210, 23);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Text = "Password";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // bSignIn
            // 
            this.bSignIn.AllowAnimations = true;
            this.bSignIn.AllowMouseEffects = true;
            this.bSignIn.AllowToggling = false;
            this.bSignIn.AnimationSpeed = 200;
            this.bSignIn.AutoGenerateColors = false;
            this.bSignIn.AutoRoundBorders = false;
            this.bSignIn.AutoSizeLeftIcon = true;
            this.bSignIn.AutoSizeRightIcon = true;
            this.bSignIn.BackColor = System.Drawing.Color.Transparent;
            this.bSignIn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.bSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSignIn.BackgroundImage")));
            this.bSignIn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bSignIn.ButtonText = "sign in";
            this.bSignIn.ButtonTextMarginLeft = 0;
            this.bSignIn.ColorContrastOnClick = 45;
            this.bSignIn.ColorContrastOnHover = 45;
            this.bSignIn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bSignIn.CustomizableEdges = borderEdges1;
            this.bSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bSignIn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bSignIn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bSignIn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bSignIn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bSignIn.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSignIn.ForeColor = System.Drawing.Color.White;
            this.bSignIn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSignIn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bSignIn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bSignIn.IconMarginLeft = 11;
            this.bSignIn.IconPadding = 10;
            this.bSignIn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSignIn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bSignIn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bSignIn.IconSize = 25;
            this.bSignIn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.bSignIn.IdleBorderRadius = 50;
            this.bSignIn.IdleBorderThickness = 1;
            this.bSignIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.bSignIn.IdleIconLeftImage = null;
            this.bSignIn.IdleIconRightImage = null;
            this.bSignIn.IndicateFocus = false;
            this.bSignIn.Location = new System.Drawing.Point(198, 435);
            this.bSignIn.Name = "bSignIn";
            this.bSignIn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bSignIn.OnDisabledState.BorderRadius = 50;
            this.bSignIn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bSignIn.OnDisabledState.BorderThickness = 1;
            this.bSignIn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bSignIn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bSignIn.OnDisabledState.IconLeftImage = null;
            this.bSignIn.OnDisabledState.IconRightImage = null;
            this.bSignIn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(201)))), ((int)(((byte)(157)))));
            this.bSignIn.onHoverState.BorderRadius = 50;
            this.bSignIn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bSignIn.onHoverState.BorderThickness = 1;
            this.bSignIn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(201)))), ((int)(((byte)(157)))));
            this.bSignIn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bSignIn.onHoverState.IconLeftImage = null;
            this.bSignIn.onHoverState.IconRightImage = null;
            this.bSignIn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.bSignIn.OnIdleState.BorderRadius = 50;
            this.bSignIn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bSignIn.OnIdleState.BorderThickness = 1;
            this.bSignIn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.bSignIn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bSignIn.OnIdleState.IconLeftImage = null;
            this.bSignIn.OnIdleState.IconRightImage = null;
            this.bSignIn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.bSignIn.OnPressedState.BorderRadius = 50;
            this.bSignIn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bSignIn.OnPressedState.BorderThickness = 1;
            this.bSignIn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(124)))));
            this.bSignIn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bSignIn.OnPressedState.IconLeftImage = null;
            this.bSignIn.OnPressedState.IconRightImage = null;
            this.bSignIn.Size = new System.Drawing.Size(192, 51);
            this.bSignIn.TabIndex = 18;
            this.bSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bSignIn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bSignIn.TextMarginLeft = 0;
            this.bSignIn.TextPadding = new System.Windows.Forms.Padding(0);
            this.bSignIn.UseDefaultRadiusAndThickness = true;
            this.bSignIn.Click += new System.EventHandler(this.bSignIn_Click);
            // 
            // bSignUp
            // 
            this.bSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(220)))), ((int)(((byte)(203)))));
            this.bSignUp.Image = ((System.Drawing.Image)(resources.GetObject("bSignUp.Image")));
            this.bSignUp.Location = new System.Drawing.Point(682, 330);
            this.bSignUp.Name = "bSignUp";
            this.bSignUp.Size = new System.Drawing.Size(192, 51);
            this.bSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bSignUp.TabIndex = 20;
            this.bSignUp.TabStop = false;
            this.bSignUp.Click += new System.EventHandler(this.bSignUp_Click);
            this.bSignUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bSignUp_MouseDown);
            this.bSignUp.MouseEnter += new System.EventHandler(this.bSignUp_MouseEnter);
            this.bSignUp.MouseLeave += new System.EventHandler(this.bSignUp_MouseLeave);
            this.bSignUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bSignUp_MouseUp);
            // 
            // lSignUp
            // 
            this.lSignUp.AutoSize = true;
            this.lSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(220)))), ((int)(((byte)(203)))));
            this.lSignUp.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSignUp.ForeColor = System.Drawing.Color.White;
            this.lSignUp.Location = new System.Drawing.Point(741, 344);
            this.lSignUp.Name = "lSignUp";
            this.lSignUp.Size = new System.Drawing.Size(71, 22);
            this.lSignUp.TabIndex = 21;
            this.lSignUp.Text = "sign up";
            this.lSignUp.Click += new System.EventHandler(this.bSignUp_Click);
            this.lSignUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bSignUp_MouseDown);
            this.lSignUp.MouseEnter += new System.EventHandler(this.bSignUp_MouseEnter);
            this.lSignUp.MouseLeave += new System.EventHandler(this.bSignUp_MouseLeave);
            this.lSignUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bSignUp_MouseUp);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.lSignUp);
            this.Controls.Add(this.bSignUp);
            this.Controls.Add(this.bSignIn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSignUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox eye;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bSignIn;
        private System.Windows.Forms.PictureBox bSignUp;
        private System.Windows.Forms.Label lSignUp;
    }
}

