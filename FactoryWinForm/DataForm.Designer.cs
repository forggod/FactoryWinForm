namespace FactoryWinForm
{
    partial class DataForm
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
            dataGridView_Data = new DataGridView();
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem_Menu = new ToolStripMenuItem();
            ToolStripMenuItem_Add = new ToolStripMenuItem();
            ToolStripMenuItem_Edit = new ToolStripMenuItem();
            ToolStripMenuItem_Delete = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Data).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Data
            // 
            dataGridView_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Data.Dock = DockStyle.Fill;
            dataGridView_Data.Location = new Point(0, 24);
            dataGridView_Data.Name = "dataGridView_Data";
            dataGridView_Data.RowTemplate.Height = 25;
            dataGridView_Data.Size = new Size(800, 426);
            dataGridView_Data.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_Menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Menu
            // 
            ToolStripMenuItem_Menu.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Add, ToolStripMenuItem_Edit, ToolStripMenuItem_Delete });
            ToolStripMenuItem_Menu.Name = "ToolStripMenuItem_Menu";
            ToolStripMenuItem_Menu.Size = new Size(53, 20);
            ToolStripMenuItem_Menu.Text = "Меню";
            // 
            // ToolStripMenuItem_Add
            // 
            ToolStripMenuItem_Add.Name = "ToolStripMenuItem_Add";
            ToolStripMenuItem_Add.Size = new Size(180, 22);
            ToolStripMenuItem_Add.Text = "Добавить";
            ToolStripMenuItem_Add.Click += ToolStripMenuItem_Add_Click;
            // 
            // ToolStripMenuItem_Edit
            // 
            ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            ToolStripMenuItem_Edit.Size = new Size(180, 22);
            ToolStripMenuItem_Edit.Text = "Изменить";
            ToolStripMenuItem_Edit.Click += ToolStripMenuItem_Edit_Click;
            // 
            // ToolStripMenuItem_Delete
            // 
            ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            ToolStripMenuItem_Delete.Size = new Size(180, 22);
            ToolStripMenuItem_Delete.Text = "Удалить";
            ToolStripMenuItem_Delete.Click += ToolStripMenuItem_Delete_Click;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_Data);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DataForm";
            Text = "DataForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Data).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Data;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem_Menu;
        private ToolStripMenuItem ToolStripMenuItem_Add;
        private ToolStripMenuItem ToolStripMenuItem_Edit;
        private ToolStripMenuItem ToolStripMenuItem_Delete;
    }
}