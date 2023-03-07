namespace lab4
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
            this.rows = new System.Windows.Forms.Label();
            this.rowsField = new System.Windows.Forms.TextBox();
            this.colsField = new System.Windows.Forms.TextBox();
            this.cols = new System.Windows.Forms.Label();
            this.maxField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generateArray = new System.Windows.Forms.Button();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.calculations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // rows
            // 
            this.rows.AutoSize = true;
            this.rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rows.Location = new System.Drawing.Point(33, 29);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(60, 25);
            this.rows.TabIndex = 0;
            this.rows.Text = "Rows";
            // 
            // rowsField
            // 
            this.rowsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowsField.Location = new System.Drawing.Point(99, 27);
            this.rowsField.Name = "rowsField";
            this.rowsField.Size = new System.Drawing.Size(72, 27);
            this.rowsField.TabIndex = 1;
            // 
            // colsField
            // 
            this.colsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colsField.Location = new System.Drawing.Point(99, 70);
            this.colsField.Name = "colsField";
            this.colsField.Size = new System.Drawing.Size(72, 27);
            this.colsField.TabIndex = 3;
            // 
            // cols
            // 
            this.cols.AutoSize = true;
            this.cols.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cols.Location = new System.Drawing.Point(33, 69);
            this.cols.Name = "cols";
            this.cols.Size = new System.Drawing.Size(52, 25);
            this.cols.TabIndex = 2;
            this.cols.Text = "Cols";
            // 
            // maxField
            // 
            this.maxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxField.Location = new System.Drawing.Point(316, 70);
            this.maxField.Name = "maxField";
            this.maxField.Size = new System.Drawing.Size(72, 27);
            this.maxField.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(208, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max value";
            // 
            // minField
            // 
            this.minField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minField.Location = new System.Drawing.Point(316, 27);
            this.minField.Name = "minField";
            this.minField.Size = new System.Drawing.Size(72, 27);
            this.minField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(208, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min value";
            // 
            // generateArray
            // 
            this.generateArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateArray.Location = new System.Drawing.Point(448, 13);
            this.generateArray.Name = "generateArray";
            this.generateArray.Size = new System.Drawing.Size(283, 50);
            this.generateArray.TabIndex = 8;
            this.generateArray.Text = "Generate Array";
            this.generateArray.UseVisualStyleBackColor = true;
            this.generateArray.Click += new System.EventHandler(this.generateArray_Click);
            // 
            // matrix
            // 
            this.matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.Location = new System.Drawing.Point(38, 133);
            this.matrix.Name = "matrix";
            this.matrix.Size = new System.Drawing.Size(693, 296);
            this.matrix.TabIndex = 9;
            // 
            // calculations
            // 
            this.calculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculations.Location = new System.Drawing.Point(448, 70);
            this.calculations.Name = "calculations";
            this.calculations.Size = new System.Drawing.Size(283, 50);
            this.calculations.TabIndex = 10;
            this.calculations.Text = "Do Calculations";
            this.calculations.UseVisualStyleBackColor = true;
            this.calculations.Click += new System.EventHandler(this.calculations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculations);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.generateArray);
            this.Controls.Add(this.maxField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colsField);
            this.Controls.Add(this.cols);
            this.Controls.Add(this.rowsField);
            this.Controls.Add(this.rows);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rows;
        private System.Windows.Forms.TextBox rowsField;
        private System.Windows.Forms.TextBox colsField;
        private System.Windows.Forms.Label cols;
        private System.Windows.Forms.TextBox maxField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateArray;
        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.Button calculations;
    }
}

