namespace FacadeApp
{
    partial class Form1
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
            this.cmbFacadeStyles = new System.Windows.Forms.ComboBox();
            this.btnCreateFacade = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFacadeStyles
            // 
            this.cmbFacadeStyles.FormattingEnabled = true;
            this.cmbFacadeStyles.Location = new System.Drawing.Point(50, 144);
            this.cmbFacadeStyles.Name = "cmbFacadeStyles";
            this.cmbFacadeStyles.Size = new System.Drawing.Size(121, 24);
            this.cmbFacadeStyles.TabIndex = 0;
            // 
            // btnCreateFacade
            // 
            this.btnCreateFacade.Location = new System.Drawing.Point(261, 144);
            this.btnCreateFacade.Name = "btnCreateFacade";
            this.btnCreateFacade.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFacade.TabIndex = 1;
            this.btnCreateFacade.Text = "Create";
            this.btnCreateFacade.UseVisualStyleBackColor = true;
            this.btnCreateFacade.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(430, 147);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(44, 16);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCreateFacade);
            this.Controls.Add(this.cmbFacadeStyles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFacadeStyles;
        private System.Windows.Forms.Button btnCreateFacade;
        private System.Windows.Forms.Label lblResult;
    }
}

