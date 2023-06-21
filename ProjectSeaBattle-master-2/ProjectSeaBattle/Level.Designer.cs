
namespace ProjectSeaBattle
{
    partial class Level
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
            this.dgvLevel = new System.Windows.Forms.DataGridView();
            this.dgvEndLevel = new System.Windows.Forms.DataGridView();
            this.buttonToRun = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.dgvMove = new System.Windows.Forms.DataGridView();
            this.instruction = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMove)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLevel
            // 
            this.dgvLevel.AllowUserToAddRows = false;
            this.dgvLevel.AllowUserToDeleteRows = false;
            this.dgvLevel.BackgroundColor = System.Drawing.Color.White;
            this.dgvLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLevel.Location = new System.Drawing.Point(32, 60);
            this.dgvLevel.Name = "dgvLevel";
            this.dgvLevel.ReadOnly = true;
            this.dgvLevel.RowTemplate.ReadOnly = true;
            this.dgvLevel.Size = new System.Drawing.Size(236, 255);
            this.dgvLevel.TabIndex = 42;
            // 
            // dgvEndLevel
            // 
            this.dgvEndLevel.AllowUserToAddRows = false;
            this.dgvEndLevel.AllowUserToDeleteRows = false;
            this.dgvEndLevel.BackgroundColor = System.Drawing.Color.White;
            this.dgvEndLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndLevel.Location = new System.Drawing.Point(534, 60);
            this.dgvEndLevel.Name = "dgvEndLevel";
            this.dgvEndLevel.ReadOnly = true;
            this.dgvEndLevel.RowTemplate.ReadOnly = true;
            this.dgvEndLevel.Size = new System.Drawing.Size(235, 255);
            this.dgvEndLevel.TabIndex = 43;
            // 
            // buttonToRun
            // 
            this.buttonToRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonToRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToRun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonToRun.Location = new System.Drawing.Point(32, 344);
            this.buttonToRun.Name = "buttonToRun";
            this.buttonToRun.Size = new System.Drawing.Size(182, 44);
            this.buttonToRun.TabIndex = 45;
            this.buttonToRun.Text = "Запустить";
            this.buttonToRun.UseVisualStyleBackColor = false;
            this.buttonToRun.Click += new System.EventHandler(this.buttonToRun_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRestart.Location = new System.Drawing.Point(32, 394);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(182, 44);
            this.buttonRestart.TabIndex = 46;
            this.buttonRestart.Text = "Начать заново";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // dgvMove
            // 
            this.dgvMove.AllowUserToAddRows = false;
            this.dgvMove.AllowUserToDeleteRows = false;
            this.dgvMove.BackgroundColor = System.Drawing.Color.White;
            this.dgvMove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMove.Location = new System.Drawing.Point(325, 95);
            this.dgvMove.Name = "dgvMove";
            this.dgvMove.ReadOnly = true;
            this.dgvMove.Size = new System.Drawing.Size(133, 220);
            this.dgvMove.TabIndex = 52;
            // 
            // instruction
            // 
            this.instruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.instruction.ForeColor = System.Drawing.Color.Black;
            this.instruction.Location = new System.Drawing.Point(0, 0);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(103, 23);
            this.instruction.TabIndex = 54;
            this.instruction.Text = "ИНСТРУКЦИЯ";
            this.instruction.UseVisualStyleBackColor = false;
            this.instruction.Click += new System.EventHandler(this.instruction_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.White;
            this.left.Image = global::ProjectSeaBattle.Properties.Resources.left2;
            this.left.Location = new System.Drawing.Point(484, 353);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(44, 44);
            this.left.TabIndex = 51;
            this.left.Tag = "4";
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.White;
            this.right.Image = global::ProjectSeaBattle.Properties.Resources.right;
            this.right.Location = new System.Drawing.Point(424, 353);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(43, 44);
            this.right.TabIndex = 50;
            this.right.Tag = "3";
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.White;
            this.down.Image = global::ProjectSeaBattle.Properties.Resources.down;
            this.down.Location = new System.Drawing.Point(359, 353);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(44, 44);
            this.down.TabIndex = 49;
            this.down.Tag = "2";
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.White;
            this.up.ForeColor = System.Drawing.Color.Black;
            this.up.Image = global::ProjectSeaBattle.Properties.Resources.up;
            this.up.Location = new System.Drawing.Point(294, 353);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(44, 44);
            this.up.TabIndex = 48;
            this.up.Tag = "1";
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.dgvMove);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonToRun);
            this.Controls.Add(this.dgvEndLevel);
            this.Controls.Add(this.dgvLevel);
            this.Name = "Level";
            this.Text = "Level";
            this.Load += new System.EventHandler(this.Level_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLevel;
        private System.Windows.Forms.DataGridView dgvEndLevel;
        private System.Windows.Forms.Button buttonToRun;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.DataGridView dgvMove;
        private System.Windows.Forms.Button instruction;
    }
}