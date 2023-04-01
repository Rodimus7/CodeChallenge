namespace RSL.TheLott
{
  partial class frmMain
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.sbStatus = new System.Windows.Forms.StatusStrip();
      this.sblStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.tbcMain = new System.Windows.Forms.TabControl();
      this.tabOpenDraws = new System.Windows.Forms.TabPage();
      this.grdOpenDraws = new System.Windows.Forms.DataGridView();
      this.grpOpenDraws = new System.Windows.Forms.GroupBox();
      this.lblMaxResults = new System.Windows.Forms.Label();
      this.lblCompany = new System.Windows.Forms.Label();
      this.lblProduct = new System.Windows.Forms.Label();
      this.cbxCompany = new System.Windows.Forms.ComboBox();
      this.clbProducts = new System.Windows.Forms.CheckedListBox();
      this.numMaxDraws = new System.Windows.Forms.NumericUpDown();
      this.btnFindOpenDraws = new System.Windows.Forms.Button();
      this.pgJurisdictions = new System.Windows.Forms.TabPage();
      this.grpLottoJurisdictions = new System.Windows.Forms.GroupBox();
      this.grdLottoJurisdictions = new System.Windows.Forms.DataGridView();
      this.grpJurisdications = new System.Windows.Forms.GroupBox();
      this.grdJurisdictions = new System.Windows.Forms.DataGridView();
      this.sbStatus.SuspendLayout();
      this.tbcMain.SuspendLayout();
      this.tabOpenDraws.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdOpenDraws)).BeginInit();
      this.grpOpenDraws.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMaxDraws)).BeginInit();
      this.pgJurisdictions.SuspendLayout();
      this.grpLottoJurisdictions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdLottoJurisdictions)).BeginInit();
      this.grpJurisdications.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdJurisdictions)).BeginInit();
      this.SuspendLayout();
      // 
      // sbStatus
      // 
      this.sbStatus.ImageScalingSize = new System.Drawing.Size(36, 36);
      this.sbStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sblStatus});
      this.sbStatus.Location = new System.Drawing.Point(0, 1055);
      this.sbStatus.Name = "sbStatus";
      this.sbStatus.Size = new System.Drawing.Size(2019, 48);
      this.sbStatus.TabIndex = 6;
      this.sbStatus.Text = "statusStrip1";
      // 
      // sblStatus
      // 
      this.sblStatus.Name = "sblStatus";
      this.sblStatus.Size = new System.Drawing.Size(115, 37);
      this.sblStatus.Text = "sbStatus";
      // 
      // tbcMain
      // 
      this.tbcMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
      this.tbcMain.Controls.Add(this.tabOpenDraws);
      this.tbcMain.Controls.Add(this.pgJurisdictions);
      this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbcMain.Location = new System.Drawing.Point(0, 0);
      this.tbcMain.Name = "tbcMain";
      this.tbcMain.SelectedIndex = 0;
      this.tbcMain.Size = new System.Drawing.Size(2019, 1055);
      this.tbcMain.TabIndex = 7;
      // 
      // tabOpenDraws
      // 
      this.tabOpenDraws.Controls.Add(this.grdOpenDraws);
      this.tabOpenDraws.Controls.Add(this.grpOpenDraws);
      this.tabOpenDraws.Location = new System.Drawing.Point(10, 10);
      this.tabOpenDraws.Name = "tabOpenDraws";
      this.tabOpenDraws.Padding = new System.Windows.Forms.Padding(3);
      this.tabOpenDraws.Size = new System.Drawing.Size(1999, 998);
      this.tabOpenDraws.TabIndex = 0;
      this.tabOpenDraws.Text = "Open Draws";
      this.tabOpenDraws.UseVisualStyleBackColor = true;
      // 
      // grdOpenDraws
      // 
      this.grdOpenDraws.AllowUserToAddRows = false;
      this.grdOpenDraws.AllowUserToDeleteRows = false;
      this.grdOpenDraws.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdOpenDraws.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdOpenDraws.Location = new System.Drawing.Point(3, 336);
      this.grdOpenDraws.Name = "grdOpenDraws";
      this.grdOpenDraws.ReadOnly = true;
      this.grdOpenDraws.RowHeadersWidth = 92;
      this.grdOpenDraws.RowTemplate.Height = 37;
      this.grdOpenDraws.Size = new System.Drawing.Size(1993, 659);
      this.grdOpenDraws.TabIndex = 6;
      // 
      // grpOpenDraws
      // 
      this.grpOpenDraws.Controls.Add(this.lblMaxResults);
      this.grpOpenDraws.Controls.Add(this.lblCompany);
      this.grpOpenDraws.Controls.Add(this.lblProduct);
      this.grpOpenDraws.Controls.Add(this.cbxCompany);
      this.grpOpenDraws.Controls.Add(this.clbProducts);
      this.grpOpenDraws.Controls.Add(this.numMaxDraws);
      this.grpOpenDraws.Controls.Add(this.btnFindOpenDraws);
      this.grpOpenDraws.Dock = System.Windows.Forms.DockStyle.Top;
      this.grpOpenDraws.Location = new System.Drawing.Point(3, 3);
      this.grpOpenDraws.Name = "grpOpenDraws";
      this.grpOpenDraws.Size = new System.Drawing.Size(1993, 333);
      this.grpOpenDraws.TabIndex = 5;
      this.grpOpenDraws.TabStop = false;
      this.grpOpenDraws.Text = "Open Draws";
      // 
      // lblMaxResults
      // 
      this.lblMaxResults.AutoSize = true;
      this.lblMaxResults.Location = new System.Drawing.Point(623, 38);
      this.lblMaxResults.Name = "lblMaxResults";
      this.lblMaxResults.Size = new System.Drawing.Size(169, 29);
      this.lblMaxResults.TabIndex = 7;
      this.lblMaxResults.Text = "Limit # Results";
      // 
      // lblCompany
      // 
      this.lblCompany.AutoSize = true;
      this.lblCompany.Location = new System.Drawing.Point(6, 38);
      this.lblCompany.Name = "lblCompany";
      this.lblCompany.Size = new System.Drawing.Size(557, 29);
      this.lblCompany.TabIndex = 6;
      this.lblCompany.Text = "Select which Companies Lotto Open Draws to Find";
      // 
      // lblProduct
      // 
      this.lblProduct.AutoSize = true;
      this.lblProduct.Location = new System.Drawing.Point(6, 140);
      this.lblProduct.Name = "lblProduct";
      this.lblProduct.Size = new System.Drawing.Size(302, 29);
      this.lblProduct.TabIndex = 5;
      this.lblProduct.Text = "Filter by Product (optional):";
      // 
      // cbxCompany
      // 
      this.cbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxCompany.FormattingEnabled = true;
      this.cbxCompany.Items.AddRange(new object[] {
            "GoldenCasket",
            "NSWLotteries",
            "NTLotteries",
            "SALotteries",
            "Tattersalls"});
      this.cbxCompany.Location = new System.Drawing.Point(11, 70);
      this.cbxCompany.Name = "cbxCompany";
      this.cbxCompany.Size = new System.Drawing.Size(552, 37);
      this.cbxCompany.TabIndex = 1;
      this.cbxCompany.SelectedIndexChanged += new System.EventHandler(this.cbxCompany_SelectedIndexChanged);
      // 
      // clbProducts
      // 
      this.clbProducts.FormattingEnabled = true;
      this.clbProducts.Location = new System.Drawing.Point(3, 184);
      this.clbProducts.Name = "clbProducts";
      this.clbProducts.Size = new System.Drawing.Size(745, 132);
      this.clbProducts.TabIndex = 3;
      // 
      // numMaxDraws
      // 
      this.numMaxDraws.Location = new System.Drawing.Point(628, 70);
      this.numMaxDraws.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numMaxDraws.Name = "numMaxDraws";
      this.numMaxDraws.Size = new System.Drawing.Size(120, 35);
      this.numMaxDraws.TabIndex = 4;
      this.numMaxDraws.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // btnFindOpenDraws
      // 
      this.btnFindOpenDraws.Location = new System.Drawing.Point(848, 91);
      this.btnFindOpenDraws.Name = "btnFindOpenDraws";
      this.btnFindOpenDraws.Size = new System.Drawing.Size(207, 149);
      this.btnFindOpenDraws.TabIndex = 2;
      this.btnFindOpenDraws.Text = "Find Open Draws";
      this.btnFindOpenDraws.UseVisualStyleBackColor = true;
      this.btnFindOpenDraws.Click += new System.EventHandler(this.btnFindOpenDraws_Click);
      // 
      // pgJurisdictions
      // 
      this.pgJurisdictions.Controls.Add(this.grpLottoJurisdictions);
      this.pgJurisdictions.Controls.Add(this.grpJurisdications);
      this.pgJurisdictions.Location = new System.Drawing.Point(10, 10);
      this.pgJurisdictions.Name = "pgJurisdictions";
      this.pgJurisdictions.Padding = new System.Windows.Forms.Padding(3);
      this.pgJurisdictions.Size = new System.Drawing.Size(1999, 998);
      this.pgJurisdictions.TabIndex = 1;
      this.pgJurisdictions.Text = "Jurisdictions";
      this.pgJurisdictions.UseVisualStyleBackColor = true;
      // 
      // grpLottoJurisdictions
      // 
      this.grpLottoJurisdictions.Controls.Add(this.grdLottoJurisdictions);
      this.grpLottoJurisdictions.Dock = System.Windows.Forms.DockStyle.Top;
      this.grpLottoJurisdictions.Location = new System.Drawing.Point(3, 313);
      this.grpLottoJurisdictions.Name = "grpLottoJurisdictions";
      this.grpLottoJurisdictions.Size = new System.Drawing.Size(1993, 310);
      this.grpLottoJurisdictions.TabIndex = 3;
      this.grpLottoJurisdictions.TabStop = false;
      this.grpLottoJurisdictions.Text = "Lotto Jurisdictions";
      // 
      // grdLottoJurisdictions
      // 
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.grdLottoJurisdictions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.grdLottoJurisdictions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.grdLottoJurisdictions.DefaultCellStyle = dataGridViewCellStyle2;
      this.grdLottoJurisdictions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdLottoJurisdictions.Location = new System.Drawing.Point(3, 31);
      this.grdLottoJurisdictions.Name = "grdLottoJurisdictions";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.grdLottoJurisdictions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.grdLottoJurisdictions.RowHeadersWidth = 92;
      this.grdLottoJurisdictions.RowTemplate.Height = 37;
      this.grdLottoJurisdictions.Size = new System.Drawing.Size(1987, 276);
      this.grdLottoJurisdictions.TabIndex = 2;
      // 
      // grpJurisdications
      // 
      this.grpJurisdications.Controls.Add(this.grdJurisdictions);
      this.grpJurisdications.Dock = System.Windows.Forms.DockStyle.Top;
      this.grpJurisdications.Location = new System.Drawing.Point(3, 3);
      this.grpJurisdications.Name = "grpJurisdications";
      this.grpJurisdications.Size = new System.Drawing.Size(1993, 310);
      this.grpJurisdications.TabIndex = 2;
      this.grpJurisdications.TabStop = false;
      this.grpJurisdications.Text = "Jurisdictions";
      // 
      // grdJurisdictions
      // 
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.grdJurisdictions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.grdJurisdictions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.grdJurisdictions.DefaultCellStyle = dataGridViewCellStyle5;
      this.grdJurisdictions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdJurisdictions.Location = new System.Drawing.Point(3, 31);
      this.grdJurisdictions.Name = "grdJurisdictions";
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.grdJurisdictions.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
      this.grdJurisdictions.RowHeadersWidth = 92;
      this.grdJurisdictions.RowTemplate.Height = 37;
      this.grdJurisdictions.Size = new System.Drawing.Size(1987, 276);
      this.grdJurisdictions.TabIndex = 2;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(2019, 1103);
      this.Controls.Add(this.tbcMain);
      this.Controls.Add(this.sbStatus);
      this.Name = "frmMain";
      this.Text = "Lotto Open Draws";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.sbStatus.ResumeLayout(false);
      this.sbStatus.PerformLayout();
      this.tbcMain.ResumeLayout(false);
      this.tabOpenDraws.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdOpenDraws)).EndInit();
      this.grpOpenDraws.ResumeLayout(false);
      this.grpOpenDraws.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMaxDraws)).EndInit();
      this.pgJurisdictions.ResumeLayout(false);
      this.grpLottoJurisdictions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdLottoJurisdictions)).EndInit();
      this.grpJurisdications.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdJurisdictions)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip sbStatus;
    private System.Windows.Forms.TabControl tbcMain;
    private System.Windows.Forms.TabPage tabOpenDraws;
    private System.Windows.Forms.DataGridView grdOpenDraws;
    private System.Windows.Forms.GroupBox grpOpenDraws;
    private System.Windows.Forms.ComboBox cbxCompany;
    private System.Windows.Forms.CheckedListBox clbProducts;
    private System.Windows.Forms.NumericUpDown numMaxDraws;
    private System.Windows.Forms.Button btnFindOpenDraws;
    private System.Windows.Forms.TabPage pgJurisdictions;
    private System.Windows.Forms.GroupBox grpLottoJurisdictions;
    private System.Windows.Forms.DataGridView grdLottoJurisdictions;
    private System.Windows.Forms.GroupBox grpJurisdications;
    private System.Windows.Forms.DataGridView grdJurisdictions;
    private System.Windows.Forms.ToolStripStatusLabel sblStatus;
    private System.Windows.Forms.Label lblMaxResults;
    private System.Windows.Forms.Label lblCompany;
    private System.Windows.Forms.Label lblProduct;
  }
}

