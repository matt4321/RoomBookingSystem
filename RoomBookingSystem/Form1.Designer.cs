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
            this.roomsListBox.ItemHeight = 16;
            this.roomsListBox.Location = new System.Drawing.Point(6, 6);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(306, 180);
            this.roomsListBox.TabIndex = 11;
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
            // 
            // lblRoomInfo
            // 
            this.lblRoomInfo.AutoSize = true;
            this.lblRoomInfo.Location = new System.Drawing.Point(6, 199);
            this.lblRoomInfo.Name = "lblRoomInfo";
            this.lblRoomInfo.Size = new System.Drawing.Size(140, 17);
            this.lblRoomInfo.TabIndex = 12;
            this.lblRoomInfo.Text = "Please select a room";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(16, 319);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(96, 30);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Location = new System.Drawing.Point(174, 193);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(138, 27);
            this.btnRemoveRoom.TabIndex = 14;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 290);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.roomsListBox);
            this.tabPage1.Controls.Add(this.btnRemoveRoom);
            this.tabPage1.Controls.Add(this.lblRoomInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 261);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Room Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Room Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add New Room";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txBxRoomName
            // 
            this.txBxRoomName.Location = new System.Drawing.Point(121, 97);
            this.txBxRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.txBxRoomName.Name = "txBxRoomName";
            this.txBxRoomName.Size = new System.Drawing.Size(169, 22);
            this.txBxRoomName.TabIndex = 17;
            // 
            // numRoomCapacity
            // 
            this.numRoomCapacity.Location = new System.Drawing.Point(121, 13);
            this.numRoomCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.numRoomCapacity.Name = "numRoomCapacity";
            this.numRoomCapacity.Size = new System.Drawing.Size(101, 22);
            this.numRoomCapacity.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Toilet Facilities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Projector";
            // 
            // chBxToiletFacilities
            // 
            this.chBxToiletFacilities.AutoSize = true;
            this.chBxToiletFacilities.Location = new System.Drawing.Point(121, 71);
            this.chBxToiletFacilities.Margin = new System.Windows.Forms.Padding(4);
            this.chBxToiletFacilities.Name = "chBxToiletFacilities";
            this.chBxToiletFacilities.Size = new System.Drawing.Size(18, 17);
            this.chBxToiletFacilities.TabIndex = 15;
            this.chBxToiletFacilities.UseVisualStyleBackColor = true;
            // 
            // chBxProjector
            // 
            this.chBxProjector.AutoSize = true;
            this.chBxProjector.Location = new System.Drawing.Point(121, 46);
            this.chBxProjector.Margin = new System.Windows.Forms.Padding(4);
            this.chBxProjector.Name = "chBxProjector";
            this.chBxProjector.Size = new System.Drawing.Size(18, 17);
            this.chBxProjector.TabIndex = 14;
            this.chBxProjector.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 359);
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

