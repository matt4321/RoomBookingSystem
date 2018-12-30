namespace RoomBookingSystem
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
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.lblRoomInfo = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txBxRoomName = new System.Windows.Forms.TextBox();
            this.numRoomCapacity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chBxToiletFacilities = new System.Windows.Forms.CheckBox();
            this.chBxProjector = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsListBox
            // 
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.ItemHeight = 20;
            this.roomsListBox.Location = new System.Drawing.Point(7, 8);
            this.roomsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(344, 224);
            this.roomsListBox.TabIndex = 11;
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
            // 
            // lblRoomInfo
            // 
            this.lblRoomInfo.AutoSize = true;
            this.lblRoomInfo.Location = new System.Drawing.Point(7, 249);
            this.lblRoomInfo.Name = "lblRoomInfo";
            this.lblRoomInfo.Size = new System.Drawing.Size(156, 20);
            this.lblRoomInfo.TabIndex = 12;
            this.lblRoomInfo.Text = "Please select a room";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(18, 399);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(108, 38);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Location = new System.Drawing.Point(196, 241);
            this.btnRemoveRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(155, 34);
            this.btnRemoveRoom.TabIndex = 14;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 362);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.roomsListBox);
            this.tabPage1.Controls.Add(this.btnRemoveRoom);
            this.tabPage1.Controls.Add(this.lblRoomInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(431, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Rooms";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txBxRoomName);
            this.tabPage2.Controls.Add(this.numRoomCapacity);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.chBxToiletFacilities);
            this.tabPage2.Controls.Add(this.chBxProjector);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(431, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Room Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Room Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add New Room";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txBxRoomName
            // 
            this.txBxRoomName.Location = new System.Drawing.Point(136, 121);
            this.txBxRoomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txBxRoomName.Name = "txBxRoomName";
            this.txBxRoomName.Size = new System.Drawing.Size(190, 26);
            this.txBxRoomName.TabIndex = 17;
            // 
            // numRoomCapacity
            // 
            this.numRoomCapacity.Location = new System.Drawing.Point(136, 16);
            this.numRoomCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numRoomCapacity.Name = "numRoomCapacity";
            this.numRoomCapacity.Size = new System.Drawing.Size(114, 26);
            this.numRoomCapacity.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Toilet Facilities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Projector";
            // 
            // chBxToiletFacilities
            // 
            this.chBxToiletFacilities.AutoSize = true;
            this.chBxToiletFacilities.Location = new System.Drawing.Point(136, 89);
            this.chBxToiletFacilities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chBxToiletFacilities.Name = "chBxToiletFacilities";
            this.chBxToiletFacilities.Size = new System.Drawing.Size(22, 21);
            this.chBxToiletFacilities.TabIndex = 15;
            this.chBxToiletFacilities.UseVisualStyleBackColor = true;
            // 
            // chBxProjector
            // 
            this.chBxProjector.AutoSize = true;
            this.chBxProjector.Location = new System.Drawing.Point(136, 58);
            this.chBxProjector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chBxProjector.Name = "chBxProjector";
            this.chBxProjector.Size = new System.Drawing.Size(22, 21);
            this.chBxProjector.TabIndex = 14;
            this.chBxProjector.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 449);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Label lblRoomInfo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txBxRoomName;
        private System.Windows.Forms.NumericUpDown numRoomCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBxToiletFacilities;
        private System.Windows.Forms.CheckBox chBxProjector;
    }
}

