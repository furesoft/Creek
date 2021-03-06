using Creek.UI;

namespace Creek.UI
{
    partial class PickList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdMoveRight = new System.Windows.Forms.Button();
            this.cmdMoveLeft = new System.Windows.Forms.Button();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblSuggested = new System.Windows.Forms.Label();
            this.cmdMoveAllRight = new System.Windows.Forms.Button();
            this.cmdMoveAllLeft = new System.Windows.Forms.Button();
            this.imageListBoxS = new ImageListBox();
            this.imageListBoxA = new ImageListBox();
            this.SuspendLayout();
            // 
            // cmdMoveRight
            // 
            this.cmdMoveRight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMoveRight.Location = new System.Drawing.Point(167, 70);
            this.cmdMoveRight.Name = "cmdMoveRight";
            this.cmdMoveRight.Size = new System.Drawing.Size(38, 27);
            this.cmdMoveRight.TabIndex = 2;
            this.cmdMoveRight.Text = "►";
            this.cmdMoveRight.UseVisualStyleBackColor = true;
            this.cmdMoveRight.Click += new System.EventHandler(this.cmdMoveRight_Click);
            // 
            // cmdMoveLeft
            // 
            this.cmdMoveLeft.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMoveLeft.Location = new System.Drawing.Point(167, 110);
            this.cmdMoveLeft.Name = "cmdMoveLeft";
            this.cmdMoveLeft.Size = new System.Drawing.Size(38, 27);
            this.cmdMoveLeft.TabIndex = 3;
            this.cmdMoveLeft.Text = "◄";
            this.cmdMoveLeft.UseVisualStyleBackColor = true;
            this.cmdMoveLeft.Click += new System.EventHandler(this.cmdMoveLeft_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(10, 13);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(53, 13);
            this.lblAvailable.TabIndex = 4;
            this.lblAvailable.Text = "Available:";
            // 
            // lblSuggested
            // 
            this.lblSuggested.AutoSize = true;
            this.lblSuggested.Location = new System.Drawing.Point(208, 13);
            this.lblSuggested.Name = "lblSuggested";
            this.lblSuggested.Size = new System.Drawing.Size(61, 13);
            this.lblSuggested.TabIndex = 5;
            this.lblSuggested.Text = "Suggested:";
            // 
            // cmdMoveAllRight
            // 
            this.cmdMoveAllRight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMoveAllRight.Location = new System.Drawing.Point(167, 37);
            this.cmdMoveAllRight.Name = "cmdMoveAllRight";
            this.cmdMoveAllRight.Size = new System.Drawing.Size(38, 27);
            this.cmdMoveAllRight.TabIndex = 6;
            this.cmdMoveAllRight.Text = "►►";
            this.cmdMoveAllRight.UseVisualStyleBackColor = true;
            this.cmdMoveAllRight.Click += new System.EventHandler(this.cmdMoveAllRight_Click);
            // 
            // cmdMoveAllLeft
            // 
            this.cmdMoveAllLeft.AutoSize = true;
            this.cmdMoveAllLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdMoveAllLeft.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMoveAllLeft.Location = new System.Drawing.Point(167, 143);
            this.cmdMoveAllLeft.Name = "cmdMoveAllLeft";
            this.cmdMoveAllLeft.Size = new System.Drawing.Size(39, 24);
            this.cmdMoveAllLeft.TabIndex = 7;
            this.cmdMoveAllLeft.Text = "◄◄";
            this.cmdMoveAllLeft.UseVisualStyleBackColor = true;
            this.cmdMoveAllLeft.Click += new System.EventHandler(this.cmdMoveAllLeft_Click);
            // 
            // imageListBoxS
            // 
            this.imageListBoxS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.imageListBoxS.FormattingEnabled = true;
            this.imageListBoxS.Location = new System.Drawing.Point(211, 29);
            this.imageListBoxS.Name = "imageListBoxS";
            this.imageListBoxS.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.imageListBoxS.Size = new System.Drawing.Size(139, 160);
            this.imageListBoxS.TabIndex = 1;
            this.imageListBoxS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.imageListBoxS_MouseDoubleClick);
            this.imageListBoxS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageListBoxS_MouseClick);
            this.imageListBoxS.SelectedIndexChanged += new System.EventHandler(this.imageListBoxS_SelectedIndexChanged);
            // 
            // imageListBoxA
            // 
            this.imageListBoxA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.imageListBoxA.FormattingEnabled = true;
            this.imageListBoxA.Location = new System.Drawing.Point(13, 29);
            this.imageListBoxA.Name = "imageListBoxA";
            this.imageListBoxA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.imageListBoxA.Size = new System.Drawing.Size(148, 160);
            this.imageListBoxA.TabIndex = 0;
            this.imageListBoxA.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.imageListBoxA_MouseDoubleClick);
            this.imageListBoxA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageListBoxA_MouseClick);
            this.imageListBoxA.SelectedIndexChanged += new System.EventHandler(this.imageListBoxA_SelectedIndexChanged);
            // 
            // PickList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.cmdMoveAllLeft);
            this.Controls.Add(this.cmdMoveAllRight);
            this.Controls.Add(this.lblSuggested);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.cmdMoveLeft);
            this.Controls.Add(this.cmdMoveRight);
            this.Controls.Add(this.imageListBoxS);
            this.Controls.Add(this.imageListBoxA);
            this.Name = "PickList";
            this.Size = new System.Drawing.Size(368, 206);
            this.Load += new System.EventHandler(this.PickList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageListBox imageListBoxA;
        private ImageListBox imageListBoxS;
        private System.Windows.Forms.Button cmdMoveRight;
        private System.Windows.Forms.Button cmdMoveLeft;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblSuggested;
        private System.Windows.Forms.Button cmdMoveAllRight;
        private System.Windows.Forms.Button cmdMoveAllLeft;
    }
}
