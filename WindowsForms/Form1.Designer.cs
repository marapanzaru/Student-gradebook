namespace atestat1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.parolatext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.baza_catalogDataSet = new atestat1.Baza_catalogDataSet();
            this.uTILIZATORIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uTILIZATORITableAdapter = new atestat1.Baza_catalogDataSetTableAdapters.UTILIZATORITableAdapter();
            this.tableAdapterManager = new atestat1.Baza_catalogDataSetTableAdapters.TableAdapterManager();
            this.eLEVITableAdapter = new atestat1.Baza_catalogDataSetTableAdapters.ELEVITableAdapter();
            this.pROFESORITableAdapter = new atestat1.Baza_catalogDataSetTableAdapters.PROFESORITableAdapter();
            this.uTILIZATORIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uTILIZATORIBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pROFESORIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLEVIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_catalogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILIZATORIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILIZATORIBindingNavigator)).BeginInit();
            this.uTILIZATORIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.parolatext);
            this.panel1.Controls.Add(this.emailtext);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(299, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 428);
            this.panel1.TabIndex = 0;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(57, 337);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(270, 57);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Log in";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // parolatext
            // 
            this.parolatext.Location = new System.Drawing.Point(19, 279);
            this.parolatext.Multiline = true;
            this.parolatext.Name = "parolatext";
            this.parolatext.Size = new System.Drawing.Size(296, 30);
            this.parolatext.TabIndex = 3;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(19, 184);
            this.emailtext.Multiline = true;
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(296, 30);
            this.emailtext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // baza_catalogDataSet
            // 
            this.baza_catalogDataSet.DataSetName = "Baza_catalogDataSet";
            this.baza_catalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uTILIZATORIBindingSource
            // 
            this.uTILIZATORIBindingSource.DataMember = "UTILIZATORI";
            this.uTILIZATORIBindingSource.DataSource = this.baza_catalogDataSet;
            // 
            // uTILIZATORITableAdapter
            // 
            this.uTILIZATORITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ABSENTETableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLASETableAdapter = null;
            this.tableAdapterManager.ELEVITableAdapter = this.eLEVITableAdapter;
            this.tableAdapterManager.MATERIITableAdapter = null;
            this.tableAdapterManager.NOTETableAdapter = null;
            this.tableAdapterManager.PROFESORITableAdapter = this.pROFESORITableAdapter;
            this.tableAdapterManager.UpdateOrder = atestat1.Baza_catalogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UTILIZATORITableAdapter = this.uTILIZATORITableAdapter;
            // 
            // eLEVITableAdapter
            // 
            this.eLEVITableAdapter.ClearBeforeFill = true;
            // 
            // pROFESORITableAdapter
            // 
            this.pROFESORITableAdapter.ClearBeforeFill = true;
            // 
            // uTILIZATORIBindingNavigator
            // 
            this.uTILIZATORIBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uTILIZATORIBindingNavigator.BindingSource = this.uTILIZATORIBindingSource;
            this.uTILIZATORIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uTILIZATORIBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uTILIZATORIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uTILIZATORIBindingNavigatorSaveItem});
            this.uTILIZATORIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uTILIZATORIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uTILIZATORIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uTILIZATORIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uTILIZATORIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uTILIZATORIBindingNavigator.Name = "uTILIZATORIBindingNavigator";
            this.uTILIZATORIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uTILIZATORIBindingNavigator.Size = new System.Drawing.Size(1061, 27);
            this.uTILIZATORIBindingNavigator.TabIndex = 1;
            this.uTILIZATORIBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // uTILIZATORIBindingNavigatorSaveItem
            // 
            this.uTILIZATORIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uTILIZATORIBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uTILIZATORIBindingNavigatorSaveItem.Image")));
            this.uTILIZATORIBindingNavigatorSaveItem.Name = "uTILIZATORIBindingNavigatorSaveItem";
            this.uTILIZATORIBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.uTILIZATORIBindingNavigatorSaveItem.Text = "Save Data";
            this.uTILIZATORIBindingNavigatorSaveItem.Click += new System.EventHandler(this.uTILIZATORIBindingNavigatorSaveItem_Click);
            // 
            // pROFESORIBindingSource
            // 
            this.pROFESORIBindingSource.DataMember = "PROFESORI";
            this.pROFESORIBindingSource.DataSource = this.baza_catalogDataSet;
            // 
            // eLEVIBindingSource
            // 
            this.eLEVIBindingSource.DataMember = "ELEVI";
            this.eLEVIBindingSource.DataSource = this.baza_catalogDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1061, 544);
            this.Controls.Add(this.uTILIZATORIBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_catalogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILIZATORIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILIZATORIBindingNavigator)).EndInit();
            this.uTILIZATORIBindingNavigator.ResumeLayout(false);
            this.uTILIZATORIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parolatext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label label1;
        private Baza_catalogDataSet baza_catalogDataSet;
        private System.Windows.Forms.BindingSource uTILIZATORIBindingSource;
        private Baza_catalogDataSetTableAdapters.UTILIZATORITableAdapter uTILIZATORITableAdapter;
        private Baza_catalogDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uTILIZATORIBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uTILIZATORIBindingNavigatorSaveItem;
        private Baza_catalogDataSetTableAdapters.PROFESORITableAdapter pROFESORITableAdapter;
        private System.Windows.Forms.BindingSource pROFESORIBindingSource;
        private Baza_catalogDataSetTableAdapters.ELEVITableAdapter eLEVITableAdapter;
        private System.Windows.Forms.BindingSource eLEVIBindingSource;
    }
}

