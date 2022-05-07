
namespace _2_laba_oop
{
    partial class Form5Lab
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.buttonOrderBy = new System.Windows.Forms.Button();
            this.buttonUnion = new System.Windows.Forms.Button();
            this.buttonIntersect = new System.Windows.Forms.Button();
            this.buttonExcept = new System.Windows.Forms.Button();
            this.buttonAgregations = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(659, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(41, 319);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(94, 37);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(179, 319);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(94, 37);
            this.buttonGroup.TabIndex = 3;
            this.buttonGroup.Text = "Group";
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // buttonJoin
            // 
            this.buttonJoin.Location = new System.Drawing.Point(329, 319);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(94, 37);
            this.buttonJoin.TabIndex = 4;
            this.buttonJoin.Text = "Join";
            this.buttonJoin.UseVisualStyleBackColor = true;
            this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
            // 
            // buttonOrderBy
            // 
            this.buttonOrderBy.Location = new System.Drawing.Point(471, 319);
            this.buttonOrderBy.Name = "buttonOrderBy";
            this.buttonOrderBy.Size = new System.Drawing.Size(94, 37);
            this.buttonOrderBy.TabIndex = 5;
            this.buttonOrderBy.Text = "OrderBy";
            this.buttonOrderBy.UseVisualStyleBackColor = true;
            this.buttonOrderBy.Click += new System.EventHandler(this.buttonOrderBy_Click);
            // 
            // buttonUnion
            // 
            this.buttonUnion.Location = new System.Drawing.Point(606, 319);
            this.buttonUnion.Name = "buttonUnion";
            this.buttonUnion.Size = new System.Drawing.Size(94, 37);
            this.buttonUnion.TabIndex = 6;
            this.buttonUnion.Text = "Union";
            this.buttonUnion.UseVisualStyleBackColor = true;
            this.buttonUnion.Click += new System.EventHandler(this.buttonUnion_Click);
            // 
            // buttonIntersect
            // 
            this.buttonIntersect.Location = new System.Drawing.Point(41, 394);
            this.buttonIntersect.Name = "buttonIntersect";
            this.buttonIntersect.Size = new System.Drawing.Size(94, 37);
            this.buttonIntersect.TabIndex = 7;
            this.buttonIntersect.Text = "Intersect";
            this.buttonIntersect.UseVisualStyleBackColor = true;
            this.buttonIntersect.Click += new System.EventHandler(this.buttonIntersect_Click);
            // 
            // buttonExcept
            // 
            this.buttonExcept.Location = new System.Drawing.Point(179, 394);
            this.buttonExcept.Name = "buttonExcept";
            this.buttonExcept.Size = new System.Drawing.Size(94, 37);
            this.buttonExcept.TabIndex = 8;
            this.buttonExcept.Text = "Except";
            this.buttonExcept.UseVisualStyleBackColor = true;
            this.buttonExcept.Click += new System.EventHandler(this.buttonExcept_Click);
            // 
            // buttonAgregations
            // 
            this.buttonAgregations.Location = new System.Drawing.Point(329, 394);
            this.buttonAgregations.Name = "buttonAgregations";
            this.buttonAgregations.Size = new System.Drawing.Size(94, 37);
            this.buttonAgregations.TabIndex = 9;
            this.buttonAgregations.Text = "Agregations";
            this.buttonAgregations.UseVisualStyleBackColor = true;
            this.buttonAgregations.Click += new System.EventHandler(this.buttonAgregations_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(471, 394);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(94, 37);
            this.buttonCount.TabIndex = 10;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // Form5Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 483);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.buttonAgregations);
            this.Controls.Add(this.buttonExcept);
            this.Controls.Add(this.buttonIntersect);
            this.Controls.Add(this.buttonUnion);
            this.Controls.Add(this.buttonOrderBy);
            this.Controls.Add(this.buttonJoin);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5Lab";
            this.Text = "Form5Lab";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.Button buttonOrderBy;
        private System.Windows.Forms.Button buttonUnion;
        private System.Windows.Forms.Button buttonIntersect;
        private System.Windows.Forms.Button buttonExcept;
        private System.Windows.Forms.Button buttonAgregations;
        private System.Windows.Forms.Button buttonCount;
    }
}