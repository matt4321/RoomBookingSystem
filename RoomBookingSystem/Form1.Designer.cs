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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numRoomCapacity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chBxProjector = new System.Windows.Forms.CheckBox();
            this.chBxToiletFacilities = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txBxRoomName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.lblRoomInfo = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCapacity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Room";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Capacity";
            // 
            // numRoomCapacity
            // 
            this.numRoomCapacity.Location = new System.Drawing.Point(167, 26);
            this.numRoomCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.numRoomCapacity.Name = "numRoomCapacity";
            this.numRoomCapacity.Size = new System.Drawing.Size(101, 22);
            this.numRoomCapacity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Projector";
            // 
            // chBxProjector
            // 
            this.chBxProjector.AutoSize = true;
            this.chBxProjector.Location = new System.Drawing.Point(167, 59);
            this.chBxProjector.Margin = new System.Windows.Forms.Padding(4);
            this.chBxProjector.Name = "chBxProjector";
            this.chBxProjector.Size = new System.Drawing.Size(18, 17);
            this.chBxProjector.TabIndex = 5;
            this.chBxProjector.UseVisualStyleBackColor = true;
            // 
            // chBxToiletFacilities
            // 
            this.chBxToiletFacilities.AutoSize = true;
            this.chBxToiletFacilities.Location = new System.Drawing.Point(167, 84);
            this.chBxToiletFacilities.Margin = new System.Windows.Forms.Padding(4);
            this.chBxToiletFacilities.Name = "chBxToiletFacilities";
            this.chBxToiletFacilities.Size = new System.Drawing.Size(18, 17);
            this.chBxToiletFacilities.TabIndex = 6;
            this.chBxToiletFacilities.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toilet Facilities";
            // 
            // txBxRoomName
            // 
            this.txBxRoomName.Location = new System.Drawing.Point(167, 110);
            this.txBxRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.txBxRoomName.Name = "txBxRoomName";
            this.txBxRoomName.Size = new System.Drawing.Size(169, 22);
            this.txBxRoomName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Room Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txBxRoomName);
            this.groupBox1.Controls.Add(this.numRoomCapacity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chBxToiletFacilities);
            this.groupBox1.Controls.Add(this.chBxProjector);
            this.groupBox1.Location = new System.Drawing.Point(346, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(352, 192);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a Room";
            // 
            // roomsListBox
            // 
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.ItemHeight = 16;
            this.roomsListBox.Location = new System.Drawing.Point(12, 15);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(306, 180);
            this.roomsListBox.TabIndex = 11;
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
            // 
            // lblRoomInfo
            // 
            this.lblRoomInfo.AutoSize = true;
            this.lblRoomInfo.Location = new System.Drawing.Point(12, 208);
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
            this.btnRemoveRoom.Location = new System.Drawing.Point(180, 202);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(138, 27);
            this.btnRemoveRoom.TabIndex = 14;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 359);
            this.Controls.Add(this.btnRemoveRoom);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblRoomInfo);
            this.Controls.Add(this.roomsListBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCapacity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRoomCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBxProjector;
        private System.Windows.Forms.CheckBox chBxToiletFacilities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txBxRoomName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Label lblRoomInfo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnRemoveRoom;
    }
}

